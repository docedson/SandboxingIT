using Accessories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widgets
{
    public abstract class Widget : IWidgets
    {
        private int _iGears;
        private int _iSprings;
        private int _iLevers;
        private Painted _painted;
        private float _Price;

        public Widget(float Price)
        {
            _Price = Price;
            _painted = new Painted();
        }

        protected float Price
        {
            get { return _Price; }
        }

        public int Gears
        {
            get
            {
                return _iGears;
            }
            set
            {
                _iGears = value;
            }
        }
        public int Springs
        {
            get
            {
                return _iSprings;
            }
            set
            {
                _iSprings = value;
            }
        }
        public int Levers
        {
            get
            {
                return _iLevers;
            }
            set
            {
                _iLevers = value;
            }
        }
        public virtual void SetupLevers(bool isgadgetOrder)
        {

        }
        public virtual void SetupGears(bool isgadgetOrder)
        {

        }
        public virtual void SetupSprings(bool isgadgetOrder)
        {

        }

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
            Console.Write("Choose an option for the widget to be decorated: (1) Painted, (2) Chrome Plated, (3) Plain: ");
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

        public void getPainted()
        {

            if (_painted.paint.Equals(Painted.Paint.painted) == true)
            {
                Console.WriteLine("The Widget is " + _painted.paint.ToString() + " " + _painted.color.ToString() +". ");
                Console.WriteLine(" ");
            }
            else if (_painted.paint.Equals(Painted.Paint.plated) == true)
            {
                Console.WriteLine("The Widget is " + _painted.paint.ToString() + " and has a surcharge of " + _painted.GetTotalPrice().ToString("C2"));
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("The Widget is " + _painted.paint.ToString());
                Console.WriteLine(" ");
            }
        }

        public void getWidgetOrderSummary()
        {
            if (this.GetType() == typeof(SmallWidget))
            {
                Console.WriteLine("This is a Small Widget. ");
            }
            else if (this.GetType() == typeof(MediumWidget))
            {
                Console.WriteLine("This is a Medium Widget. ");
            }
            else
            {
                Console.WriteLine("This is a Large Widget. ");
            }
        }

        public float getWidgetPrice()
        {
            float fTotalPrice = _Price;

            if (_painted.getIsPlated() == true)
            {
                fTotalPrice += _painted.GetTotalPrice();
            }

            return fTotalPrice;
        }
    }
}