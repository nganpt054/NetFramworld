using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFBasic.Dal;
using IFBasic.Viewmodel;

namespace IFBasic.BLL
{
    internal class LophocBLL
    {
        public static List<Lophoc> GetList()
        {
            QLSinhvienModel model = new QLSinhvienModel();
             var ls = model.Lophocs.ToList();
            return ls;
        }

        public static List<LophocViewmodel> GetViewmodels()
        {
            QLSinhvienModel model = new QLSinhvienModel();
            var ls = model.Lophocs.Select(e => new LophocViewmodel
            {
                ID = e.ID,
                Name = e.Name,
                TotalStudent = e.Sinhviens.Count,
            }).ToList();
            return ls;

        }
        public static bool Delete (long idLophoc)
        {
            QLSinhvienModel model = new QLSinhvienModel();
            var lopHoc = model.Lophocs.Where(e => e.ID == idLophoc).FirstOrDefault();
            if(lopHoc.Sinhviens.Count == 0)
            {
                model.Lophocs.Remove(lopHoc);
                model.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool Update(LophocViewmodel lopHocVM)
        {
            QLSinhvienModel model = new QLSinhvienModel();
            var lop = model.Lophocs.Where(e =>
            e.ID != lopHocVM.ID && e.Name == lopHocVM.Name).FirstOrDefault();
            if (lop != null)
            {
                return false;
            }
            else
            {
                lop = model.Lophocs.Where(e => e.ID == lopHocVM.ID).FirstOrDefault();
                lop.Name = lopHocVM.Name;

                model.SaveChanges();
                return true;
            }
        }



    }
}
