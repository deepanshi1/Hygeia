using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hygeia1.Models
{
    public class Member
    {
        private int ID { get; set; }
        public string Name { get; set; }
        public string AboutMe { get; set; }
        //public Dictionary<int, string> MemberDictionary;
        public Member(string Name, String AboutMe)
        {
            this.Name = Name;
            this.AboutMe = AboutMe;
        }

        public Member() { }
        public static Member ReturnMember(int ID)
        {

            String AboutDeepanshi = "Deepanshi is a good girl. OMG. She is amazing";
            String ABoutVanshaj = "Vanshaj is a really cool guy. Yeah. :P Kidding";
            String AboutTushar = "Tushar lallu hai. But a handsome Lallu with great hair";
            Dictionary<int, Member> DicName = new Dictionary<int, Member>() 
            {  
                    {1, new Member("Deepanshi Jain", AboutDeepanshi)},
                    {2, new Member("Vanshaj SIkri", ABoutVanshaj)},
                    {3, new Member("Tushar Kundra", AboutTushar)}    
            };
            return DicName[ID];

        }

    }


}

       
      