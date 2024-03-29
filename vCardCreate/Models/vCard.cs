﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vCardCreate.Models
{
    public class vCard
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Organization { get; set; }
        public string JobTitle { get; set; }
        public string StreetAddress { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public byte[] Image { get; set; }

        public string GetFullName() {

            return FirstName + LastName;
        }
        public override string  ToString()
        {
            var builder = new StringBuilder();
           
            //STARTING
            builder.AppendLine("BEGIN:VCARD");
            builder.AppendLine("VERSION:2.1");
            
            //NAME
            builder.Append("N:").Append(LastName).Append(";").AppendLine(FirstName);
           
            //FULL NAME
            builder.Append("FN:").Append(FirstName).Append(" ").AppendLine(LastName);
            
            // Address   
            builder.Append("ADR;HOME;PREF:;;").Append(StreetAddress).Append(";").Append(City).Append(";").Append(Zip).Append(";").AppendLine(CountryName);

            builder.Append("ORG:").AppendLine(Organization);
            builder.Append("TITLE:").AppendLine(JobTitle);
            builder.Append("TEL;WORK;VOICE:").AppendLine(Phone);
            builder.Append("TEL;CELL;VOICE:").AppendLine(Mobile);
            builder.Append("URL:").AppendLine(HomePage);
            builder.Append("EMAIL;PREF;INTERNET:").AppendLine(Email);

            //Image

            if (Image != null) { 
            builder.AppendLine("PHOTO;ENCODING=BASE64;TYPE=JPEG:");
            builder.AppendLine(Convert.ToBase64String(Image));
            builder.AppendLine(String.Empty);
            }
            builder.AppendLine("END:VCARD");
            return builder.ToString();
        }
    }
}
