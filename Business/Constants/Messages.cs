using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Mehsul elave edildi";
        public static string ProductNameInvalid = "Mehsulun adi kecersizdir";
        public static string MaintenanceTime ="Sistem baximdadir!";
        public static string ProductsListed ="Mehsullar listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride 10-dan artiq mehsul ola bilmez";
        public static string ProductNameAlreadyExists="Bu add mehsul zaten var";
        public static string CategoryLimitExceded = "Kategori limiti kecildiyi ucun mehsul elave edilmir";
        public static string AuthorizationDenied="Icazeniz yoxdur!!!.";
    }
}
