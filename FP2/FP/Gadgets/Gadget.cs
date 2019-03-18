using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accessories;
using Widgets;

namespace Gadgets
{
    public abstract class Gadget : IGadget
    {
        private ArrayList _Widgets = new ArrayList();
        private Switch _Switches;
        private Buttons _Buttons;
        private Lights _Lights;
        private float _Price;
        private Painted _painted;
        //private Powered _power;
        //private static Powered _powerStatic = new Powered();


        private int _iTotalGears = 0;
        private int _iTotalSprings = 0;
        private int _iTotalLevers = 0;
        private float _fTotalWidgetPrice = 0.0f;

        private bool _isgadgetOrder = false;
        private string _sDefaultWidgetColor;

        protected int _defaultButtons;
        protected int _defaultSwitches;
        protected int _defaultLights;
        //protected Powered _defaultPower;


        public Gadget(float price)//, Powered.Power power)
        {
            _Price = price;
            _Switches = new Switch();
            _Buttons = new Buttons();
            _Lights = new Lights();
            _painted = new Painted();
            //_power = new Powered();
            //_power.DefaultPower = power;
        }

        public float Price
        {
            get { return _Price; }
        }

        public int Switches
        {
            get
            {
                return _Switches.Quantity;
            }
            set
            {
                _Switches.Quantity = value;
            }
        }

        public bool isgadgetOrder
        {
            get
            {
                return _isgadgetOrder;
            }
            set
            {
                _isgadgetOrder = value;
            }
        }
        public string sDefaultWidgetColor
        {
            get
            {
                return _sDefaultWidgetColor;
            }
            set
            {
                _sDefaultWidgetColor = value;
            }
        }

        protected string SwitchPrice
        {
            get
            {
                return _Switches.Price.ToString("C2");
            }
        }
        public int Buttons
        {
            get
            {
                return _Buttons.Quantity;
            }
            set
            {
                _Buttons.Quantity = value;
            }
        }
        protected string ButtonPrice
        {
            get
            {
                return _Buttons.Price.ToString("C2");
            }
        }
        public int Lights
        {
            get
            {
                return _Lights.Quantity;
            }
            set
            {
                _Lights.Quantity = value;
            }
        }
        protected string LightPrice
        {
            get
            {
                return _Lights.Price.ToString("C2");
            }
        }

        /*protected void SetPower(Powered.Power gPower)
        {
            _power.power = gPower;
        }

        public string GetPower()
        {
            switch (_power.power)
            {
                case Powered.Power.solar:
                    return "Solar";
                case Powered.Power.battery:
                    return "Battery";
                default:
                    return "Generator";
            }
        }*/

        public void AddSmallWidgets(int iNum)
        {
            for (int ii = 0; ii < iNum; ii++)
            {
                SmallWidget sw = new SmallWidget();
                AddWidget(sw);
            }
        }

        public void AddMediumWidgets(int iNum)
        {
            for (int ii = 0; ii < iNum; ii++)
            {
                MediumWidget mw = new MediumWidget();
                AddWidget(mw);
            }
        }

        public void AddLargeWidgets(int iNum)
        {
            for (int ii = 0; ii < iNum; ii++)
            {
                LargeWidget lw = new LargeWidget();
                AddWidget(lw);
            }
        }

        private void AddWidget(IWidgets iw)
        {
            _Widgets.Add(iw);
            iw.SetupGears(_isgadgetOrder);
            iw.SetupLevers(_isgadgetOrder);
            iw.SetupSprings(_isgadgetOrder);
            if (!_isgadgetOrder)
            {
                ((Widget)iw).SetupPainted();
            }
            else
            {
                ((Widget)iw).SetupPaintedDefault(_sDefaultWidgetColor);
            }
        }

        public virtual void SetupWidgets()
        {
        }

        public virtual void SetupLights()
        {
        }

        public virtual void SetupSwitches()
        {
        }

        public virtual void SetupButtons()
        {

        }

        public virtual void SetupPower()
        {

        }

        /*public string GetGadgetPowerPrice()
        {
            return _power.GetTotalPrice();
        }

        protected static float GetGadgetPowerPrice(int option)
        {
            return _powerStatic.PowerPrice[option];
        }*/

        public void SetupPaintedDefault(string sColor)
        { 
            _painted.paint = Painted.Paint.painted;
            switch (sColor)
            {
                case "Black":
                case "black":
                    _painted.color = Painted.Colors.Black;
                    break;
                case "Green":
                case "green":
                    _painted.color = Painted.Colors.Green;
                    break;
                case "Brown":
                case "brown":
                    _painted.color = Painted.Colors.Brown;
                    break;
                case "Blue":
                case "blue":
                    _painted.color = Painted.Colors.Blue;
                    break;
                case "Yellow":
                case "yellow":
                    _painted.color = Painted.Colors.Yellow;
                    break;
                case "Violet":
                case "violet":
                    _painted.color = Painted.Colors.Violet;
                    break;
                case "Red":
                case "red":
                    _painted.color = Painted.Colors.Red;
                    break;
                default:
                    _painted.color = Painted.Colors.Gold;
                    break;
            }
        }

        public void SetupPainted()
        {
            Console.Write("Choose an option for the Gadget to be decorated: (1) Painted, (2) Chrome Plated, (3) Plain: ");
            int sPainted = Convert.ToInt32(Console.ReadLine());
            
            switch (sPainted)
            {
                case 1:                    
                    _painted.paint = Painted.Paint.painted;
                    Console.Write("What color would you like: (1) Black, (2) Green, (3) Brown, (4) Blue, (5) Yellow, (6) Violet, (7) Red, (8) Gold?: ");
                    int sColor = Convert.ToInt32(Console.ReadLine());
                    
                    switch (sColor)
                    {
                        case 1:
                            _painted.color = Painted.Colors.Black;
                            break;
                        case 2:
                            _painted.color = Painted.Colors.Green;
                            break;
                        case 3:
                            _painted.color = Painted.Colors.Brown;
                            break;
                        case 4:
                            _painted.color = Painted.Colors.Blue;
                            break;
                        case 5:
                            _painted.color = Painted.Colors.Yellow;
                            break;
                        case 6:
                            _painted.color = Painted.Colors.Violet;
                            break;
                        case 7:
                            _painted.color = Painted.Colors.Red;
                            break;
                        case 8:
                            _painted.color = Painted.Colors.Gold;
                            break;
                    }
                    break;
                case 2:
                    _painted.paint = Painted.Paint.plated;
                    break;
                case 3:
                    _painted.paint = Painted.Paint.plain;
                    break;
            }
        }

        public void GetPainted()
        {

            if (_painted.paint.Equals(Painted.Paint.painted) == true)
            {
                Console.WriteLine("The Gadget is " + _painted.paint.ToString() + " " + _painted.color.ToString());
            }
            else if (_painted.paint.Equals(Painted.Paint.plated) == true)
            {
                Console.WriteLine("The Gadget is " + _painted.paint.ToString() + " and has a surcharge of " + _painted.GetTotalPrice().ToString("C2"));
            }
            else
            {
                Console.WriteLine("The Gadget is " + _painted.paint.ToString());
            }
        }

        public void GetWidgetOrderSummary()
        {
            Console.WriteLine("This order has a total of  " + _Widgets.Count.ToString() + " Widgets");

            foreach (IWidgets wi in _Widgets)
            {
                ((Widget)wi).getWidgetOrderSummary();
                ((Widget)wi).getPainted();
                _fTotalWidgetPrice += ((Widget)wi).getWidgetPrice();
                _iTotalGears += ((Widget)wi).Gears;
                _iTotalSprings += ((Widget)wi).Springs;
                _iTotalLevers += ((Widget)wi).Levers;
            }

            Console.WriteLine("This order includes the following items: ");
            Console.WriteLine("- " + _iTotalGears.ToString() + " Gears");
            Console.WriteLine("- " + _iTotalLevers.ToString() + " Levers");
            Console.WriteLine("- " + _iTotalSprings.ToString() + " Springs");
            Console.WriteLine("Subtotal Widget Price       : \t{0,20}", _fTotalWidgetPrice.ToString("C2"));
        }

        public void GetWidgetOrderSummary(out int iTotalWidgets, out int iTotalGears, out int iTotalSprings, out int iTotalLevers)
        {
            iTotalGears = 0;
            iTotalSprings = 0;
            iTotalLevers = 0;
            iTotalWidgets = _Widgets.Count;

            foreach (IWidgets wi in _Widgets)
            {
                _fTotalWidgetPrice += ((Widget)wi).getWidgetPrice();
                iTotalGears += ((Widget)wi).Gears;
                iTotalSprings += ((Widget)wi).Springs;
                iTotalLevers += ((Widget)wi).Levers;
            }
        }

        public float GetGadgetOrderTotalPrice()
        {
            float fTotalWGadgetPrice = Price /*+ _power.GetTotalPriceMoney()*/ + _painted.GetTotalPrice();
            if (!_isgadgetOrder)
            {
                Console.WriteLine("Subtotal Gadget Price       : \t{0,20}", fTotalWGadgetPrice.ToString("C2"));
            }

            return fTotalWGadgetPrice + +_fTotalWidgetPrice;
        }
    }
}