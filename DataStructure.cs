using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prescription_Renewal
{
    public static class ValidationConst
    {
        public const string EMAIL_REGEX = @"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
        public const string PrescriptionMask = "Rx 0000000-0000";
        public const string PhoneMask = "(000) 000-0000";
        public const int PhoneExtensionMaxLength = 5;
    }
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string PhoneExtension { get; set; }
        public string EMail { get; set; }

        public static string ReformatName(string name)
        {
            // exemple: jean-françois devient Jean-François
            string reformattedName = "";
            for (int i = 0; i < name.Length; i++)
            {
                if ((i == 0) || ((i > 0) && (name[i - 1] == '\'' || name[i - 1] == '-')))
                    reformattedName += char.ToUpper(name[i]);
                else
                    reformattedName += char.ToLower(name[i]);
            }
            return reformattedName;
        }

        public Client()
        {
            FirstName = "";
            LastName = "";
            Phone = "";
            PhoneExtension = "";
            EMail = "";
        }
        public void Draw(Graphics DC, ref PointF location)
        {
            Brush blueBrush = new SolidBrush(Color.Blue);
            float fontSize = 14.5F;
            float lineSpace = 8.0F;
            Font font = new Font("Arial", fontSize);
            DC.DrawString("Client:", font, blueBrush, location);
            location.Y += fontSize + lineSpace;
            DC.DrawString(FirstName + " " + LastName, font, blueBrush, location);
            location.Y += fontSize + lineSpace;
            DC.DrawString(Phone + (PhoneExtension != "" ? " poste " + PhoneExtension : ""), font, blueBrush, location);
            location.Y += fontSize + lineSpace;
            DC.DrawString(EMail, font, blueBrush, location);
            location.Y += fontSize + lineSpace;
        }
    }
    public class Store
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public static Store Parse(string line)
        {
            Store store = new Store();
            try
            {
                // Find Id
                int spacePos = line.IndexOf(' ');
                store.Id = int.Parse(line.Substring(0, spacePos));

                // Find Town/State
                int statePos = line.IndexOf(" Qc") - 1;
                int townPos = statePos;
                while (line[townPos] != ' ') townPos--;
                store.Town = line.Substring(townPos + 1, statePos - townPos);
                store.State = "Qc";

                // Find Address
                int commaPos = line.IndexOf(',');
                int addressPos = commaPos + 2;
                store.Address = line.Substring(spacePos + 1, commaPos - spacePos - 1);
                store.Address += " " + line.Substring(commaPos + 2, townPos - (commaPos + 2));

                // Find ZipCode
                store.ZipCode = line.Substring(statePos + 5, 7);

                // Find Phone
                store.Phone = line.Substring(statePos + 13, 12);

                return store;
            }
            catch (Exception)
            {
                // Todo report error
            }
            return null;
        }

        public override string ToString()
        {
            string text;
            text = Town + ", " + Address;
            return text;
        }
        public void Draw(Graphics DC, ref PointF location)
        {
            Brush greenBrush = new SolidBrush(Color.Green);
            float fontSize = 14.5F;
            float lineSpace = 8.0F;
            Font font = new Font("Arial", fontSize);
            DC.DrawString("Succursale:", font, greenBrush, location);
            location.Y += fontSize + lineSpace;
            DC.DrawString(Address, font, greenBrush, location);
            location.Y += fontSize + lineSpace;
            DC.DrawString(Town + " " + State + " " + ZipCode, font, greenBrush, location);
            location.Y += fontSize + lineSpace;
            DC.DrawString(Phone, font, greenBrush, location);
            location.Y += fontSize + lineSpace;
            location.Y += fontSize + lineSpace;
        }
    }
    public class Stores
    {
        private List<Store> items = new List<Store>();
        public Stores(string data)
        {
            string[] lines = data.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                Store store = Store.Parse(line);
                if (store != null)
                    items.Add(store);
            }
        }
        public int Count { get { return items.Count; } }
        public Store this[int index]
        {
            get { if (index >= 0 && index < Count) return items[index]; else return null; }
            set { if (index >= 0 && index < Count) items[index] = value; }
        }

        public Store FindByZipCode(string zipCode)
        {
            foreach (Store store in items)
            {
                if (string.Compare(store.ZipCode.Substring(0, 3).ToUpper(), zipCode.ToUpper()) == 0)
                    return store;
            }
            return null;
        }
        public int IndexOf(int id)
        {
            for (int index = 0; index < Count; index++)
            {
                if (this[index].Id == id)
                    return index;
            }
            return -1;
        }
    }
    public class PrescriptionRenewal
    {
        public Store Store { get; set; }
        public Client Client { get; set; }
        public List<string> PrescriptionNumbers { get; set; }
        public string Comment { get; set; }

        public PrescriptionRenewal()
        {
            PrescriptionNumbers = new List<string>();
            Client = new Client();
        }
        public void Add_Prescription(string number)
        {
            if (!PrescriptionNumbers.Contains(number))
                PrescriptionNumbers.Add(number);
        }
        public void Remove_Prescription(string number)
        {
            int index = PrescriptionNumbers.IndexOf(number);
            if (index > -1)
                RemoveAt_Prescription(index);
        }
        public void RemoveAt_Prescription(int index)
        {
            PrescriptionNumbers.RemoveAt(index);
        }
        private void DrawPrescriptionNumbers(Graphics DC, ref PointF location)
        {
            Brush blackBrush = new SolidBrush(Color.Black);
            float fontSize = 14.5F;
            float lineSpace = 8.0F;
            Font font = new Font("Arial", fontSize);
            location.Y += fontSize + lineSpace;
            DC.DrawString("Numéros d'ordonnance:", font, blackBrush, location);
            foreach (string prescriptionNumber in PrescriptionNumbers)
            {
                location.Y += fontSize + lineSpace;
                DC.DrawString(prescriptionNumber, font, blackBrush, location);
            }
            location.Y += fontSize + lineSpace;
            location.Y += fontSize + lineSpace;
        }
        private void DrawComment(Graphics DC, ref PointF location)
        {
            if (Comment != "")
            {
                Brush redBrush = new SolidBrush(Color.Red);
                float fontSize = 14.5F;
                float lineSpace = 8.0F;
                Font font = new Font("Arial", fontSize);
                DC.DrawString("Commentaire:", font, redBrush, location);
                location.Y += fontSize + lineSpace;
                RectangleF border = new RectangleF(location, new SizeF(550.0F, 300.0F));
                DC.DrawString(Comment, font, redBrush, border);
                location.Y += 70.0F + lineSpace;
            }
        }
        public void Draw(Graphics DC, ref PointF location)
        {
            if (Store != null) Store.Draw(DC, ref location);
            if (Client != null) Client.Draw(DC, ref location);
            DrawPrescriptionNumbers(DC, ref location);
            DrawComment(DC, ref location);
        }
    }
}
