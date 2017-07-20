using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace WheelOfLuck.Model
{
    public class Wheel: NotificationObject
    {

        public Wheel()
        {
            _wheelPies = new List<WheelPie>();
        }

     


        private readonly List<WheelPie> _wheelPies;
        public List<WheelPie> WheelPies
        {
            get { return _wheelPies; }
        }
	


    }
}
