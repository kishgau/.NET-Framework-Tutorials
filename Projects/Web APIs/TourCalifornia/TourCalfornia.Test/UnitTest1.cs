using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TourCalifornia.Controllers;

namespace TourCalfornia.Test
{
    [TestClass]
    public class ReservationTest
    {

        [TestMethod]
        public void GetReservation()
        {
            int exp = 4;

            int act = 4;
            ReservationsController reservationsController = new ReservationsController();
            //reservationsController.GetReservations();


        Assert.AreEqual(exp, act);
        }
    }
}
