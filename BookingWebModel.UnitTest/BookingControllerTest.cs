﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit.Extensions;
using Xunit;
using System.Web.Mvc;
using Ploeh.Samples.Booking.WebUI.Controllers;

namespace Ploeh.Samples.Booking.WebModel.UnitTest
{
    public class BookingControllerTest
    {
        [Theory, AutoWebData]
        public void SutIsController(BookingController sut)
        {
            Assert.IsAssignableFrom<IController>(sut);
        }
    }
}
