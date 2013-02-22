using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_du_stock
{
    public static class DataBase
    {
        private static stockEntities dbContext;
        public static stockEntities context
        {
            get
            {
                if (dbContext == null)
                {
                    dbContext = new stockEntities();
                }
                return dbContext;
            }
        }
        /// <summary>
        /// Vider la base de données
        /// </summary>
        public static void Truncate()
        {
            while (DataBase.context.Interventions.Count() > 0)
            {
                DataBase.context.DeleteObject(DataBase.context.Interventions.First());
                DataBase.context.SaveChanges();
            }
            while (DataBase.context.Items.Count() > 0)
            {
                DataBase.context.DeleteObject(DataBase.context.Items.First());
                DataBase.context.SaveChanges();
            }
            while (DataBase.context.Equipments.Count() > 0)
            {
                DataBase.context.DeleteObject(DataBase.context.Equipments.First());
                DataBase.context.SaveChanges();
            }
            while (DataBase.context.ItemInterventions.Count() > 0)
            {
                DataBase.context.DeleteObject(DataBase.context.ItemInterventions.First());
                DataBase.context.SaveChanges();
            }
        }
        /// <summary>
        /// Inserer les données de test
        /// </summary>
        public static void InsertTestDataSet()
        {
            var a = new Intervention() { startedDate = null, endedDate = null, name = "Intervention prete", checkingState = E_InterventionCheckingState.waiting };
            DataBase.context.AddToInterventions(a);

            var a2 = new Intervention() { startedDate = null, endedDate = null, name = "Intervention vide", checkingState = E_InterventionCheckingState.waiting };
            DataBase.context.AddToInterventions(a2);

           // var b = new Intervention() { startedDate = DataBase.DateTimeToTimestamp(new DateTime(2010, 10, 10)), endedDate = null, name = "Intervention en cours" };
           // DataBase.context.AddToInterventions(b);

            var b2 = new Intervention() { startedDate = DataBase.DateTimeToTimestamp(new DateTime(2010, 10, 10)), endedDate = DataBase.DateTimeToTimestamp(new DateTime(2010, 10, 11)), name = "Intervention qui date", checkingState = E_InterventionCheckingState.done }; DataBase.context.AddToInterventions(b2);

            var c = new Equipment() { name = "Bouteille d'oxygene", maxUses = 50 };
            DataBase.context.AddToEquipments(c);

            var c2 = new Equipment() { name = "Mousqueton", maxUses = 5 };
            DataBase.context.AddToEquipments(c2);

            var c3 = new Equipment() { name = "Buse de lance" };
            DataBase.context.AddToEquipments(c3);

            var c4 = new Equipment() { name = "Echelle 30m" };
            DataBase.context.AddToEquipments(c4);

            var c5 = new Equipment() { name = "Corde d'escalade", maxUses = 5 };
            DataBase.context.AddToEquipments(c5);

            var c6 = new Equipment() { name = "Couverture de survie", maxUses = 1 };
            DataBase.context.AddToEquipments(c6);

            var d = new Item() { serialNumber = "ea5sad", expiryDate = DataBase.DateTimeToTimestamp(DateTime.Now), buyingDate = DataBase.DateTimeToTimestamp(new DateTime(2010, 10, 10)), barCode = 1 };
            d.EquipmentReference.Value = c;
            DataBase.context.AddToItems(d);

            var d2 = new Item() { serialNumber = "a4684", expiryDate = null, buyingDate = DataBase.DateTimeToTimestamp(new DateTime(2010, 10, 10)), barCode = 2 };
            d2.EquipmentReference.Value = c;
            DataBase.context.AddToItems(d2);

            var d3 = new Item() { serialNumber = "876378", expiryDate = DataBase.DateTimeToTimestamp(new DateTime(2010, 11, 10)), buyingDate = DataBase.DateTimeToTimestamp(new DateTime(2010, 10, 10)), barCode = 3 };
            d3.EquipmentReference.Value = c2;
            DataBase.context.AddToItems(d3);

            var d4 = new Item() { serialNumber = "eFfff", expiryDate = null, buyingDate = DataBase.DateTimeToTimestamp(new DateTime(2010, 10, 10)), barCode = 4, state = (int)E_ItemState.trashed };
            d4.EquipmentReference.Value = c2;
            DataBase.context.AddToItems(d4);

            var d5 = new Item() { serialNumber = "example-bis", buyingDate = DataBase.DateTimeToTimestamp(DateTime.Now), barCode = 5 };
            d5.EquipmentReference.Value = c2;
            DataBase.context.AddToItems(d5);

            var d6 = new Item() { serialNumber = "example", buyingDate = DataBase.DateTimeToTimestamp(DateTime.Now), barCode = 6 };
            d6.EquipmentReference.Value = c;
            DataBase.context.AddToItems(d6);

            var e = new ItemIntervention();
            e.InterventionReference.Value = b2;
            e.ItemReference.Value = d;
            DataBase.context.AddToItemInterventions(e);

            var e2 = new ItemIntervention();
            e2.InterventionReference.Value = b2;
            e2.ItemReference.Value = d2;
            DataBase.context.AddToItemInterventions(e2);

            var e3 = new ItemIntervention();
            e3.InterventionReference.Value = b2;
            e3.ItemReference.Value = d3;
            DataBase.context.AddToItemInterventions(e3);

            var e4 = new ItemIntervention();
            e4.InterventionReference.Value = b2;
            e4.ItemReference.Value = d4;
            DataBase.context.AddToItemInterventions(e4);

            DataBase.context.SaveChanges();

        }
        /// <summary>
        /// Converti un datetime en timsetamp
        /// </summary>
        /// <param name="value">Object DateTime</param>
        /// <returns></returns>
        public static String DateTimeToTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssfff");
        }
        /// <summary>
        /// Bourrin ... You don't say ?
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime TimestampToDateTime(String value)
        {
            var yyyy = Int32.Parse(value.Substring(0, 4));
            var MM = Int32.Parse(value.Substring(4, 2));
            var dd = Int32.Parse(value.Substring(6, 2));
            var hh = Int32.Parse(value.Substring(8, 2));
            var mm = Int32.Parse(value.Substring(10, 2));
            var ss = Int32.Parse(value.Substring(12, 2));
            var fff = Int32.Parse(value.Substring(14, 3));
            return new DateTime(yyyy, MM, dd, hh, mm, ss, fff);
        }
        /// <summary>
        /// Réaliser un test de montée en charge de la base de données
        /// </summary>
        public static void HighLoadTest()
        {

        }
    }
    /* enum ItemState
     {
            bought,
             trashed,
             lost
     }*/
}

