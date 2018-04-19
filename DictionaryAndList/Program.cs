using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryAndList {
    class Abbreviation {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    class Program {
        static void Main (string[] args) {
            Abbreviation abbreviationOne = new Abbreviation() {
                Code = "MON",
                Name ="Monday"
            };
            Abbreviation abbreviationTwo = new Abbreviation() {
                Code = "TUE",
                Name ="Tuesday"
            }; Abbreviation abbreviationThree = new Abbreviation() {
                Code = "WED",
                Name ="Wednesday"
            }; Abbreviation abbreviationFour = new Abbreviation() {
                Code = "THU",
                Name ="Thursday"
            }; Abbreviation abbreviationFive = new Abbreviation() {
                Code = "FRI",
                Name ="Friday"
            }; Abbreviation abbreviationSix = new Abbreviation() {
                Code = "SAT",
                Name ="Saturday"
            }; Abbreviation abbreviationSeven = new Abbreviation() {
                Code = "SUN",
                Name ="Sunday"
            };

            List<Abbreviation> AbbreviationList = new List<Abbreviation>();
            AbbreviationList.Add(abbreviationOne);
            AbbreviationList.Add(abbreviationTwo);
            AbbreviationList.Add(abbreviationThree);
            AbbreviationList.Add(abbreviationFour);
            AbbreviationList.Add(abbreviationFive);
            AbbreviationList.Add(abbreviationSix);
            AbbreviationList.Add(abbreviationSeven);

            Console.Write("Enter a code to get an abbreviation.");
            Console.Write("For example Mon or mon which will give Monday");
            Console.Write("----");
            Console.WriteLine();
            string EnterCode = Console.ReadLine().ToUpper();

            Abbreviation returnAbs = AbbreviationList.Find(ab => ab.Code == EnterCode);
            Console.WriteLine("The abbreviation for "+EnterCode +" is "+returnAbs.Name);

            Dictionary<string, Abbreviation> DictionaryAbbreviation = new Dictionary<string, Abbreviation>();
            //DictionaryAbbreviation.Add(abbreviationOne.Code, abbreviationOne);
            //DictionaryAbbreviation.Add(abbreviationTwo.Code, abbreviationTwo);
            //DictionaryAbbreviation.Add(abbreviationThree.Code, abbreviationThree);
            //DictionaryAbbreviation.Add(abbreviationFour.Code, abbreviationFour);
            //DictionaryAbbreviation.Add(abbreviationFive.Code, abbreviationFive);
            //DictionaryAbbreviation.Add(abbreviationSix.Code, abbreviationSix);
            //DictionaryAbbreviation.Add(abbreviationSeven.Code, abbreviationSeven);


            //if (DictionaryAbbreviation.ContainsKey(EnterCode)) { 

            //    Abbreviation abss = DictionaryAbbreviation[EnterCode];

            //    Console.WriteLine("The abbreviation for "+EnterCode +" is "+abss.Name);

            //}
            //else {
            //    Console.WriteLine("Invalid key");
            //}
        }
    }
}
