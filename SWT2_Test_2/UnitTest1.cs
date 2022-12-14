////using System;
////using System.IO;
////using ClassLibrary;
////using NUnit.Framework;
////using SWT2;

//using NUnit.Framework;

//namespace SWT2_Test
//{
  

//    [TestFixture]
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
//            //IChargeControl mockCharge= new MockChargeControl();
//        }
////namespace SWT2_Test
////{
////    //

////    [TestFixture]

////    public class Tests
////    {
////        [SetUp]
////        public void Setup()
////        {
////            //IChargeControl mockCharge= new MockChargeControl();

////        }

////        [Test]
////        public void Test1()
////        {
////            Assert.Pass();
////        }


////        #region RFIDReaderTests

////        /* [Test]
 
////         public void RFIDTagReader()
////         {
////             int id = 1234;
////             IRFIDReader uut = new RFIDReader();
 
////             Assert.
////         }
         
 
////         #endregion
 
////         #region DisplayTests
 
////         [Test]
         
////         public void ConnectionTest()
////         {
////             var stringwriter = new StringWriter();
////             Console.SetOut(stringwriter);
 
////             IDisplay uut = new Display();
////             uut.Connection();
 
////             string actulstring = stringwriter.ToString();
 
////             Assert.Equals(actulstring, "Phone is connected\r\n");
             
////         }
 
////         [Test]
////         public void LoadRFIDTest()
////         {
////             var stringwriter = new StringWriter();
////             Console.SetOut(stringwriter);
 
////             IDisplay uut = new Display();
////             uut.LoadRFID();
 
////             string actulstring = stringwriter.ToString();
 
////             Assert.Equals(actulstring, "Load your RFID\r\n");
////         }
 
////         [Test]
////         public void ConnectionErrorTest()
////         {
////             var stringwriter = new StringWriter();
////             Console.SetOut(stringwriter);
 
////             IDisplay uut = new Display();
////             uut.ConnectionError();
 
////             string actulstring = stringwriter.ToString();
 
////             Assert.Equals(actulstring, "Phone is NOT connected - an error occurred\r\n");
////         }
 
////         [Test]
////         public void OccupiedTest()
////         {
////             var stringwriter = new StringWriter();
////             Console.SetOut(stringwriter);
 
////             IDisplay uut = new Display();
////             uut.Occupied();
 
////             string actulstring = stringwriter.ToString();
 
////             Assert.Equals(actulstring, "Charger is occupied\r\n");
////         }
 
////         [Test]
////         public void RFIDErrorTest()
////         {
////             var stringwriter = new StringWriter();
////             Console.SetOut(stringwriter);
 
////             IDisplay uut = new Display();
////             uut.RFIDError();
 
////             string actulstring = stringwriter.ToString();
 
////             Assert.Equals(actulstring, "RFID not loaded - an error occurred\r\n");
////         }
 
////         [Test]
////         public void RemovePhoneTest()
////         {
////             var stringwriter = new StringWriter();
////             Console.SetOut(stringwriter);
 
////             IDisplay uut = new Display();
////             uut.RemovePhone();
 
////             string actulstring = stringwriter.ToString();
 
////             Assert.Equals(actulstring, "Please remove phone\r\n");
////         }
 
////         [Test]
////         public void FullyChargedTest()
////         {
////             var stringwriter = new StringWriter();
////             Console.SetOut(stringwriter);
 
////             IDisplay uut = new Display();
////             uut.FullyCharged();
 
////             string actulstring = stringwriter.ToString();
 
////             Assert.Equals(actulstring, "Phone is fully charged\r\n");
////         }
 
////         [Test]
////         public void PhoneChargingTest()
////         {
////             var stringwriter = new StringWriter();
////             Console.SetOut(stringwriter);
 
////             IDisplay uut = new Display();
////             uut.PhoneCharging();
 
////             string actulstring = stringwriter.ToString();
 
////             Assert.Equals(actulstring, "Phone is charging\r\n");
////         }
 
////         [Test]
////         public void ChargeErrorTest()
////         {
////             var stringwriter = new StringWriter();
////             Console.SetOut(stringwriter);
 
////             IDisplay uut = new Display();
////             uut.ChargeError();
 
////             string actulstring = stringwriter.ToString();
 
////             Assert.Equals(actulstring, "Phone is NOT Charging - an error occurred\r\n");
////         }
////         #endregion
 
////         #region StationControlTests
 
////         [TestCase(true, StationControl.LadeskabState.DoorOpen)]
////         [TestCase(false, StationControl.LadeskabState.Available)]
////         public void DoorStateChangeEvent(bool doorState, StationControl.LadeskabState expectedState)
////         {
////             /*IChargeControl stubChargeControl = new StubChargeControl();
////             IDisplay stubDisplay = new StubDisplay();
////             IRFIDReader stubRfidReader = new StubRfidReader();
////             ILogFile stubLogFile = new StubLogFile();
////             IDoor stubDoor = new StubDoor();
 
////             StationControl uut = new StationControl(stubChargeControl, stubDoor, stubDisplay, stubRfidReader, stubLogFile);
 
 
 
////             Assert.AreSame(uut.DoorState, expectedState);*/


////        #endregion

////        #region ChargeControlTests


////        /* [Test]
////         public void RFIDTagReader()
////         {
////             int id = 1234;
////             IRFIDReader uut = new RFIDReader();
 
////             Assert.
////         }*/


////        #endregion

////        #region DisplayTests

////        [Test]

////        public void ConnectionTest()
////        {
////            var stringwriter = new StringWriter();
////            Console.SetOut(stringwriter);

////            IDisplay uut = new Display();
////            uut.Connection();

////            string actulstring = stringwriter.ToString();

////            Assert.Equals(actulstring, "Phone is connected\r\n");

////        }

////        [Test]
////        public void LoadRFIDTest()
////        {
////            var stringwriter = new StringWriter();
////            Console.SetOut(stringwriter);

////            IDisplay uut = new Display();
////            uut.LoadRFID();

////            string actulstring = stringwriter.ToString();

////            Assert.Equals(actulstring, "Load your RFID\r\n");
////        }

////        [Test]
////        public void ConnectionErrorTest()
////        {
////            var stringwriter = new StringWriter();
////            Console.SetOut(stringwriter);

////            IDisplay uut = new Display();
////            uut.ConnectionError();

////            string actulstring = stringwriter.ToString();

////            Assert.Equals(actulstring, "Phone is NOT connected - an error occurred\r\n");
////        }

////        [Test]
////        public void OccupiedTest()
////        {
////            var stringwriter = new StringWriter();
////            Console.SetOut(stringwriter);

////            IDisplay uut = new Display();
////            uut.Occupied();

////            string actulstring = stringwriter.ToString();

////            Assert.Equals(actulstring, "Charger is occupied\r\n");
////        }

////        [Test]
////        public void RFIDErrorTest()
////        {
////            var stringwriter = new StringWriter();
////            Console.SetOut(stringwriter);

////            IDisplay uut = new Display();
////            uut.RFIDError();

////            string actulstring = stringwriter.ToString();

////            Assert.Equals(actulstring, "RFID not loaded - an error occurred\r\n");
////        }

////        [Test]
////        public void RemovePhoneTest()
////        {
////            var stringwriter = new StringWriter();
////            Console.SetOut(stringwriter);

////            IDisplay uut = new Display();
////            uut.RemovePhone();

////            string actulstring = stringwriter.ToString();

////            Assert.Equals(actulstring, "Please remove phone\r\n");
////        }

////        [Test]
////        public void FullyChargedTest()
////        {
////            var stringwriter = new StringWriter();
////            Console.SetOut(stringwriter);

////            IDisplay uut = new Display();
////            uut.FullyCharged();

////            string actulstring = stringwriter.ToString();

////            Assert.Equals(actulstring, "Phone is fully charged\r\n");
////        }

////        [Test]
////        public void PhoneChargingTest()
////        {
////            var stringwriter = new StringWriter();
////            Console.SetOut(stringwriter);

////            IDisplay uut = new Display();
////            uut.PhoneCharging();

////            string actulstring = stringwriter.ToString();

////            Assert.Equals(actulstring, "Phone is charging\r\n");
////        }

////        [Test]
////        public void ChargeErrorTest()
////        {
////            var stringwriter = new StringWriter();
////            Console.SetOut(stringwriter);

////            IDisplay uut = new Display();
////            uut.ChargeError();

////            string actulstring = stringwriter.ToString();

////            Assert.Equals(actulstring, "Phone is NOT Charging - an error occurred\r\n");
////        }

////        #endregion
////    }

////}
/////*
////#region DisplayTests

////[Test]

////public void ConnectionTest()
////{
////    var stringwriter = new StringWriter();
////    Console.SetOut(stringwriter);

////    IDisplay uut = new Display();
////    uut.Connection();

////    string actulstring = stringwriter.ToString();

////    Assert.Equals(actulstring, "Phone is connected\r\n");

////}

////[Test]
////public void LoadRFIDTest()
////{
////    var stringwriter = new StringWriter();
////    Console.SetOut(stringwriter);

////    IDisplay uut = new Display();
////    uut.LoadRFID();

////    string actulstring = stringwriter.ToString();

////    Assert.Equals(actulstring, "Load your RFID\r\n");
////}

////[Test]
////public void ConnectionErrorTest()
////{
////    var stringwriter = new StringWriter();
////    Console.SetOut(stringwriter);

////    IDisplay uut = new Display();
////    uut.ConnectionError();

////    string actulstring = stringwriter.ToString();

////    Assert.Equals(actulstring, "Phone is NOT connected - an error occurred\r\n");
////}

////[Test]
////public void OccupiedTest()
////{
////    var stringwriter = new StringWriter();
////    Console.SetOut(stringwriter);

////    IDisplay uut = new Display();
////    uut.Occupied();

////    string actulstring = stringwriter.ToString();

////    Assert.Equals(actulstring, "Charger is occupied\r\n");
////}

////[Test]
////public void RFIDErrorTest()
////{
////    var stringwriter = new StringWriter();
////    Console.SetOut(stringwriter);

////    IDisplay uut = new Display();
////    uut.RFIDError();

////    string actulstring = stringwriter.ToString();

////    Assert.Equals(actulstring, "RFID not loaded - an error occurred\r\n");
////}

////[Test]
////public void RemovePhoneTest()
////{
////    var stringwriter = new StringWriter();
////    Console.SetOut(stringwriter);

////    IDisplay uut = new Display();
////    uut.RemovePhone();

////    string actulstring = stringwriter.ToString();

////    Assert.Equals(actulstring, "Please remove phone\r\n");
////}

////[Test]
////public void FullyChargedTest()
////{
////    var stringwriter = new StringWriter();
////    Console.SetOut(stringwriter);

////    IDisplay uut = new Display();
////    uut.FullyCharged();

////    string actulstring = stringwriter.ToString();

////    Assert.Equals(actulstring, "Phone is fully charged\r\n");
////}

////[Test]
////public void PhoneChargingTest()
////{
////    var stringwriter = new StringWriter();
////    Console.SetOut(stringwriter);

////    IDisplay uut = new Display();
////    uut.PhoneCharging();

////    string actulstring = stringwriter.ToString();

////    Assert.Equals(actulstring, "Phone is charging\r\n");
////}

////[Test]
////public void ChargeErrorTest()
////{
////    var stringwriter = new StringWriter();
////    Console.SetOut(stringwriter);

////    IDisplay uut = new Display();
////    uut.ChargeError();

////    string actulstring = stringwriter.ToString();

////    Assert.Equals(actulstring, "Phone is NOT Charging - an error occurred\r\n");
////}
////#endregion

////#region StationControlTests

////[TestCase(true, StationControl.LadeskabState.DoorOpen)]
////[TestCase(false, StationControl.LadeskabState.Available)]
////public void DoorStateChangeEvent(bool doorState, StationControl.LadeskabState expectedState)
////{
////    /*IChargeControl stubChargeControl = new StubChargeControl();
////    IDisplay stubDisplay = new StubDisplay();
////    IRFIDReader stubRfidReader = new StubRfidReader();
////    ILogFile stubLogFile = new StubLogFile();
////    IDoor stubDoor = new StubDoor();

////    StationControl uut = new StationControl(stubChargeControl, stubDoor, stubDisplay, stubRfidReader, stubLogFile);



////    Assert.AreSame(uut.DoorState, expectedState);
////}
////#endregion
////*/

////        #region StationControlTests
////        /*
////        [TestCase(true, StationControl.LadeskabState.DoorOpen)]
////        [TestCase(false, StationControl.LadeskabState.Available)]
////        public void DoorStateChangeEvent(bool doorState, StationControl.LadeskabState expectedState)
////        {
////            IChargeControl stubChargeControl = new StubChargeControl();
////            IDisplay stubDisplay = new StubDisplay();
////            IRFIDReader stubRfidReader = new StubRfidReader();
////            ILogFile stubLogFile = new StubLogFile();
////            IDoor stubDoor = new StubDoor();

////            StationControl uut = new StationControl(stubChargeControl, stubDoor, stubDisplay, stubRfidReader, stubLogFile);



////            Assert.AreSame(uut.DoorState, expectedState);
////        }
////        */
////#endregion

////    #region ChargeControlTests
////    //[Test]
////    //    public void Test2()
////    //    {
////    //        Assert.Pass();
////    //    }

////        #endregion

////        #region DoorTests

////        [Test]
////        public void DoorLockedTest()
////        {
////            IDoor uut = new Door();
////            uut.DoorLock();
////            Assert.That(uut.locked == true);
////        }

////        public void DoorUnlockedTest()
////        {
////            IDoor uut = new Door();
////            uut.DoorUnlock();
////            Assert.That(uut.locked == false);
////        }

////        public void DoorOpenedTest()
////        {
////            IDoor uut = new Door();
////            uut.DoorOpened();
////            Assert.That(uut._open == true);
////        }

////        public void DoorClosedTest()
////        {
////            IDoor uut = new Door();
////            uut.DoorClosed();
////            Assert.That(uut._open == false);
////        }

////        #endregion


////        #region Handout_tests

/////*
    

////    [TestFixture]
////    public class TestUsbChargerSimulator
////    {
        
////        private UsbChargerSimulator _uut;
////        [SetUp]
////        public void Setup()
////        {
////            _uut = new UsbChargerSimulator();
////        }
        
////        [Test]
////        public void ctor_IsConnected()
////        {
////            Assert.That(_uut.Connected, Is.True);
////        }

////        [Test]
////        public void ctor_CurentValueIsZero()
////        {
////            Assert.That(_uut.CurrentValue, Is.Zero);
////        }

////        [Test]
////        public void SimulateDisconnected_ReturnsDisconnected()
////        {
////            _uut.SimulateConnected(false);
////            Assert.That(_uut.Connected, Is.False);
////        }

////        [Test]
////        public void Started_WaitSomeTime_ReceivedSeveralValues()
////        {
////            int numValues = 0;
////            _uut.CurrentValueEvent += (o, args) => numValues++;

////            _uut.StartCharge();

////            System.Threading.Thread.Sleep(1100);

////            Assert.That(numValues, Is.GreaterThan(4));
////        }

////        [Test]
////        public void Started_WaitSomeTime_ReceivedChangedValue()
////        {
////            double lastValue = 1000;
////            _uut.CurrentValueEvent += (o, args) => lastValue = args.Current;

////            _uut.StartCharge();

////            System.Threading.Thread.Sleep(300);

////            Assert.That(lastValue, Is.LessThan(500.0));
////        }

////        [Test]
////        public void StartedNoEventReceiver_WaitSomeTime_PropertyChangedValue()
////        {
////            _uut.StartCharge();

////            System.Threading.Thread.Sleep(300);

////            Assert.That(_uut.CurrentValue, Is.LessThan(500.0));
////        }

////        [Test]
////        public void Started_WaitSomeTime_PropertyMatchesReceivedValue()
////        {
////            double lastValue = 1000;
////            _uut.CurrentValueEvent += (o, args) => lastValue = args.Current;

////            _uut.StartCharge();

////            System.Threading.Thread.Sleep(1100);

////            Assert.That(lastValue, Is.EqualTo(_uut.CurrentValue));
////        }


////        [Test]
////        public void Started_SimulateOverload_ReceivesHighValue()
////        {
////            ManualResetEvent pause = new ManualResetEvent(false);
////            double lastValue = 0;

////            _uut.CurrentValueEvent += (o, args) =>
////            {
////                lastValue = args.Current;
////                pause.Set();
////            };

////            // Start
////            _uut.StartCharge();

//          //  Assert.AreEqual(actulstring, "Phone is connected\r\n");
            
//        }
////            // Next value should be high
////            _uut.SimulateOverload(true);

////            // Reset event
////            pause.Reset();

////            // Wait for next tick, should send overloaded value
////            pause.WaitOne(300);

////            Assert.That(lastValue, Is.GreaterThan(500.0));
////        }

////        [Test]
////        public void Started_SimulateDisconnected_ReceivesZero()
////        {
////            ManualResetEvent pause = new ManualResetEvent(false);
////            double lastValue = 1000;

//           // Assert.AreEqual(actulstring, "Load your RFID\r\n");
//        }
////            _uut.CurrentValueEvent += (o, args) =>
////            {
////                lastValue = args.Current;
////                pause.Set();
////            };


////            // Start
////            _uut.StartCharge();

////            // Next value should be zero
////            _uut.SimulateConnected(false);

//          //  Assert.AreEqual(actulstring, "Phone is NOT connected - an error occurred\r\n");
//        }
////            // Reset event
////            pause.Reset();

////            // Wait for next tick, should send disconnected value
////            pause.WaitOne(300);

////            Assert.That(lastValue, Is.Zero);
////        }

////        [Test]
////        public void SimulateOverload_Start_ReceivesHighValueImmediately()
////        {
////            double lastValue = 0;

//            Assert.AreEqual(actulstring, "Charger is occupied\r\n");
//        }
////            _uut.CurrentValueEvent += (o, args) =>
////            {
////                lastValue = args.Current;
////            };

////            // First value should be high
////            _uut.SimulateOverload(true);

////            // Start
////            _uut.StartCharge();

////            // Should not wait for first tick, should send overload immediately

//            Assert.AreEqual(actulstring, "RFID not loaded - an error occurred\r\n");
//        }
////            Assert.That(lastValue, Is.GreaterThan(500.0));
////        }

////        [Test]
////        public void SimulateDisconnected_Start_ReceivesZeroValueImmediately()
////        {
////            double lastValue = 1000;

////            _uut.CurrentValueEvent += (o, args) =>
////            {
////                lastValue = args.Current;
////            };

////            // First value should be high
////            _uut.SimulateConnected(false);

//            Assert.AreEqual(actulstring, "Please remove phone\r\n");
//        }
////            // Start
////            _uut.StartCharge();

////            // Should not wait for first tick, should send zero immediately

////            Assert.That(lastValue, Is.Zero);
////        }

////        [Test]
////        public void StopCharge_IsCharging_ReceivesZeroValue()
////        {
////            double lastValue = 1000;
////            _uut.CurrentValueEvent += (o, args) => lastValue = args.Current;

//            Assert.AreEqual(actulstring, "Phone is fully charged\r\n");
//        }
////            _uut.StartCharge();

////            System.Threading.Thread.Sleep(300);

////            _uut.StopCharge();

////            Assert.That(lastValue, Is.EqualTo(0.0));
////        }

//            Assert.AreEqual(actulstring, "Phone is charging\r\n");
//        }
////        [Test]
////        public void StopCharge_IsCharging_PropertyIsZero()
////        {
////            _uut.StartCharge();

////            System.Threading.Thread.Sleep(300);

////            _uut.StopCharge();

////            Assert.That(_uut.CurrentValue, Is.EqualTo(0.0));
////        }

//            Assert.AreEqual(actulstring, "Phone is NOT Charging - an error occurred\r\n");
//        }
//        #endregion
////        [Test]
////        public void StopCharge_IsCharging_ReceivesNoMoreValues()
////        {
////            double lastValue = 1000;
////            _uut.CurrentValueEvent += (o, args) => lastValue = args.Current;

////            _uut.StartCharge();

////            System.Threading.Thread.Sleep(300);

////            _uut.StopCharge();
////            lastValue = 1000;

////            // Wait for a tick
////            System.Threading.Thread.Sleep(300);

////            // No new value received
////            Assert.That(lastValue, Is.EqualTo(1000.0));
////        }


//        #endregion
        


//        #region Handout_tests

///*
    

//    [TestFixture]
//    public class TestUsbChargerSimulator
//    {
        
//        private UsbChargerSimulator _uut;
//        [SetUp]
//        public void Setup()
//        {
//            _uut = new UsbChargerSimulator();
//        }
        
//        [Test]
//        public void ctor_IsConnected()
//        {
//            Assert.That(_uut.Connected, Is.True);
//        }

//        [Test]
//        public void ctor_CurentValueIsZero()
//        {
//            Assert.That(_uut.CurrentValue, Is.Zero);
//        }

//        [Test]
//        public void SimulateDisconnected_ReturnsDisconnected()
//        {
//            _uut.SimulateConnected(false);
//            Assert.That(_uut.Connected, Is.False);
//        }

//        [Test]
//        public void Started_WaitSomeTime_ReceivedSeveralValues()
//        {
//            int numValues = 0;
//            _uut.CurrentValueEvent += (o, args) => numValues++;

//            _uut.StartCharge();

//            System.Threading.Thread.Sleep(1100);

//            Assert.That(numValues, Is.GreaterThan(4));
//        }

//        [Test]
//        public void Started_WaitSomeTime_ReceivedChangedValue()
//        {
//            double lastValue = 1000;
//            _uut.CurrentValueEvent += (o, args) => lastValue = args.Current;

//            _uut.StartCharge();

//            System.Threading.Thread.Sleep(300);

//            Assert.That(lastValue, Is.LessThan(500.0));
//        }

//        [Test]
//        public void StartedNoEventReceiver_WaitSomeTime_PropertyChangedValue()
//        {
//            _uut.StartCharge();

//            System.Threading.Thread.Sleep(300);

//            Assert.That(_uut.CurrentValue, Is.LessThan(500.0));
//        }

//        [Test]
//        public void Started_WaitSomeTime_PropertyMatchesReceivedValue()
//        {
//            double lastValue = 1000;
//            _uut.CurrentValueEvent += (o, args) => lastValue = args.Current;

//            _uut.StartCharge();

//            System.Threading.Thread.Sleep(1100);

//            Assert.That(lastValue, Is.EqualTo(_uut.CurrentValue));
//        }


//        [Test]
//        public void Started_SimulateOverload_ReceivesHighValue()
//        {
//            ManualResetEvent pause = new ManualResetEvent(false);
//            double lastValue = 0;

//            _uut.CurrentValueEvent += (o, args) =>
//            {
//                lastValue = args.Current;
//                pause.Set();
//            };

//            // Start
//            _uut.StartCharge();

//            // Next value should be high
//            _uut.SimulateOverload(true);

//            // Reset event
//            pause.Reset();

//            // Wait for next tick, should send overloaded value
//            pause.WaitOne(300);

//            Assert.That(lastValue, Is.GreaterThan(500.0));
//        }

//        [Test]
//        public void Started_SimulateDisconnected_ReceivesZero()
//        {
//            ManualResetEvent pause = new ManualResetEvent(false);
//            double lastValue = 1000;

//            _uut.CurrentValueEvent += (o, args) =>
//            {
//                lastValue = args.Current;
//                pause.Set();
//            };


//            // Start
//            _uut.StartCharge();

//            // Next value should be zero
//            _uut.SimulateConnected(false);

//            // Reset event
//            pause.Reset();

//            // Wait for next tick, should send disconnected value
//            pause.WaitOne(300);

//            Assert.That(lastValue, Is.Zero);
//        }

//        [Test]
//        public void SimulateOverload_Start_ReceivesHighValueImmediately()
//        {
//            double lastValue = 0;

//            _uut.CurrentValueEvent += (o, args) =>
//            {
//                lastValue = args.Current;
//            };

//            // First value should be high
//            _uut.SimulateOverload(true);

//            // Start
//            _uut.StartCharge();

//            // Should not wait for first tick, should send overload immediately

//            Assert.That(lastValue, Is.GreaterThan(500.0));
//        }

//        [Test]
//        public void SimulateDisconnected_Start_ReceivesZeroValueImmediately()
//        {
//            double lastValue = 1000;

//            _uut.CurrentValueEvent += (o, args) =>
//            {
//                lastValue = args.Current;
//            };

//            // First value should be high
//            _uut.SimulateConnected(false);

//            // Start
//            _uut.StartCharge();

//            // Should not wait for first tick, should send zero immediately

//            Assert.That(lastValue, Is.Zero);
//        }

//        [Test]
//        public void StopCharge_IsCharging_ReceivesZeroValue()
//        {
//            double lastValue = 1000;
//            _uut.CurrentValueEvent += (o, args) => lastValue = args.Current;

//            _uut.StartCharge();

//            System.Threading.Thread.Sleep(300);

//            _uut.StopCharge();

//            Assert.That(lastValue, Is.EqualTo(0.0));
//        }

//        [Test]
//        public void StopCharge_IsCharging_PropertyIsZero()
//        {
//            _uut.StartCharge();

//            System.Threading.Thread.Sleep(300);

//            _uut.StopCharge();

//            Assert.That(_uut.CurrentValue, Is.EqualTo(0.0));
//        }

//        [Test]
//        public void StopCharge_IsCharging_ReceivesNoMoreValues()
//        {
//            double lastValue = 1000;
//            _uut.CurrentValueEvent += (o, args) => lastValue = args.Current;

//            _uut.StartCharge();

//            System.Threading.Thread.Sleep(300);

//            _uut.StopCharge();
//            lastValue = 1000;

//            // Wait for a tick
//            System.Threading.Thread.Sleep(300);

//            // No new value received
//            Assert.That(lastValue, Is.EqualTo(1000.0));
//        }



//    }
//    */

//        #endregion
//    }
//}

    

////    }
////    */

////        #endregion
////    }
////}

    
////        /*
////                  #region ChargeControlTests
////                  [Test]
////              public void Test2()
////              {
////                  Assert.Pass();
////              }
////              #endregion
             
////              #region DoorTests
////              [Test]
////              public void DoorLockedTest()
////              {
////                  IDoor uut = new Door();
////                  uut.DoorLock();
////                  Assert.That(uut.locked == true);
////              }
              
////              public void DoorUnlockedTest()
////              {
////                  IDoor uut = new Door();
////                  uut.DoorUnlock();
////                  Assert.That(uut.locked == false);
////              }
      
////              public void DoorOpenedTest()
////              {
////                  IDoor uut = new Door();
////                  uut.DoorOpened();
////                  Assert.That(uut._open == true);
////              }
              
////              public void DoorClosedTest()
////              {
////                  IDoor uut = new Door();
////                  uut.DoorClosed();
////                  Assert.That(uut._open == false);
////              }
      
////              #endregion
////          }
////          /*
////          #region Handout_tests
      
          
      
////          [TestFixture]
////          public class TestUsbChargerSimulator
////          {
              
////              private UsbChargerSimulator _uut;
////              [SetUp]
////              public void Setup()
////              {
////                  _uut = new UsbChargerSimulator();
////              }
              
////              [Test]
////              public void ctor_IsConnected()
////              {
////                  Assert.That(_uut.Connected, Is.True);
////              }
      
////              [Test]
////              public void ctor_CurentValueIsZero()
////              {
////                  Assert.That(_uut.CurrentValue, Is.Zero);
////              }
      
////              [Test]
////              public void SimulateDisconnected_ReturnsDisconnected()
////              {
////                  _uut.SimulateConnected(false);
////                  Assert.That(_uut.Connected, Is.False);
////              }
      
////              [Test]
////              public void Started_WaitSomeTime_ReceivedSeveralValues()
////              {
////                  int numValues = 0;
////                  _uut.CurrentValueEvent += (o, args) => numValues++;
      
////                  _uut.StartCharge();
      
////                  System.Threading.Thread.Sleep(1100);
      
////                  Assert.That(numValues, Is.GreaterThan(4));
////              }
      
////              [Test]
////              public void Started_WaitSomeTime_ReceivedChangedValue()
////              {
////                  double lastValue = 1000;
////                  _uut.CurrentValueEvent += (o, args) => lastValue = args.Current;
      
////                  _uut.StartCharge();
      
////                  System.Threading.Thread.Sleep(300);
      
////                  Assert.That(lastValue, Is.LessThan(500.0));
////              }
      
////              [Test]
////              public void StartedNoEventReceiver_WaitSomeTime_PropertyChangedValue()
////              {
////                  _uut.StartCharge();
      
////                  System.Threading.Thread.Sleep(300);
      
////                  Assert.That(_uut.CurrentValue, Is.LessThan(500.0));
////              }
      
////              [Test]
////              public void Started_WaitSomeTime_PropertyMatchesReceivedValue()
////              {
////                  double lastValue = 1000;
////                  _uut.CurrentValueEvent += (o, args) => lastValue = args.Current;
      
////                  _uut.StartCharge();
      
////                  System.Threading.Thread.Sleep(1100);
      
////                  Assert.That(lastValue, Is.EqualTo(_uut.CurrentValue));
////              }
      
      
////              [Test]
////              public void Started_SimulateOverload_ReceivesHighValue()
////              {
////                  ManualResetEvent pause = new ManualResetEvent(false);
////                  double lastValue = 0;
      
////                  _uut.CurrentValueEvent += (o, args) =>
////                  {
////                      lastValue = args.Current;
////                      pause.Set();
////                  };
      
////                  // Start
////                  _uut.StartCharge();
      
////                  // Next value should be high
////                  _uut.SimulateOverload(true);
      
////                  // Reset event
////                  pause.Reset();
      
////                  // Wait for next tick, should send overloaded value
////                  pause.WaitOne(300);
      
////                  Assert.That(lastValue, Is.GreaterThan(500.0));
////              }
      
////              [Test]
////              public void Started_SimulateDisconnected_ReceivesZero()
////              {
////                  ManualResetEvent pause = new ManualResetEvent(false);
////                  double lastValue = 1000;
      
////                  _uut.CurrentValueEvent += (o, args) =>
////                  {
////                      lastValue = args.Current;
////                      pause.Set();
////                  };
      
      
////                  // Start
////                  _uut.StartCharge();
      
////                  // Next value should be zero
////                  _uut.SimulateConnected(false);
      
////                  // Reset event
////                  pause.Reset();
      
////                  // Wait for next tick, should send disconnected value
////                  pause.WaitOne(300);
      
////                  Assert.That(lastValue, Is.Zero);
////              }
      
////              [Test]
////              public void SimulateOverload_Start_ReceivesHighValueImmediately()
////              {
////                  double lastValue = 0;
      
////                  _uut.CurrentValueEvent += (o, args) =>
////                  {
////                      lastValue = args.Current;
////                  };
      
////                  // First value should be high
////                  _uut.SimulateOverload(true);
      
////                  // Start
////                  _uut.StartCharge();
      
////                  // Should not wait for first tick, should send overload immediately
      
////                  Assert.That(lastValue, Is.GreaterThan(500.0));
////              }
      
////              [Test]
////              public void SimulateDisconnected_Start_ReceivesZeroValueImmediately()
////              {
////                  double lastValue = 1000;
      
////                  _uut.CurrentValueEvent += (o, args) =>
////                  {
////                      lastValue = args.Current;
////                  };
      
////                  // First value should be high
////                  _uut.SimulateConnected(false);
      
////                  // Start
////                  _uut.StartCharge();
      
////                  // Should not wait for first tick, should send zero immediately
      
////                  Assert.That(lastValue, Is.Zero);
////              }
      
////              [Test]
////              public void StopCharge_IsCharging_ReceivesZeroValue()
////              {
////                  double lastValue = 1000;
////                  _uut.CurrentValueEvent += (o, args) => lastValue = args.Current;
      
////                  _uut.StartCharge();
      
////                  System.Threading.Thread.Sleep(300);
      
////                  _uut.StopCharge();
      
////                  Assert.That(lastValue, Is.EqualTo(0.0));
////              }
      
////              [Test]
////              public void StopCharge_IsCharging_PropertyIsZero()
////              {
////                  _uut.StartCharge();
      
////                  System.Threading.Thread.Sleep(300);
      
////                  _uut.StopCharge();
      
////                  Assert.That(_uut.CurrentValue, Is.EqualTo(0.0));
////              }
      
////              [Test]
////              public void StopCharge_IsCharging_ReceivesNoMoreValues()
////              {
////                  double lastValue = 1000;
////                  _uut.CurrentValueEvent += (o, args) => lastValue = args.Current;
      
////                  _uut.StartCharge();
      
////                  System.Threading.Thread.Sleep(300);
      
////                  _uut.StopCharge();
////                  lastValue = 1000;
      
////                  // Wait for a tick
////                  System.Threading.Thread.Sleep(300);
      
////                  // No new value received
////                  Assert.That(lastValue, Is.EqualTo(1000.0));
////              }
      
      
      
////          }
          
////          #endregion
      
////          */
////    }
////}
