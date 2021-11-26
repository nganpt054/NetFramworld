using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2.Entities
{
   public class Faculty
    {
        //
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public static List<Faculty> GetList()
        {
            List<Faculty> List = new List<Faculty>();
            List.Add(new Faculty
            {

                Id="1",
                Name="Khoa CNTT"
           
            });
            List.Add(new Faculty
            {

                Id = "2",
                Name = "Khoa Sử"

            });
            List.Add(new Faculty
            {

                Id = "3",
                Name = "Khoa Báo"

            });
            return List;
        }

    }
}
