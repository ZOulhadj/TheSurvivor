using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSurvivor.Source
{
    enum KeyEvent
    { 
        KEY_PRESSED,
        KEY_RELEASED
    }

    class Input
    {
        private Dictionary<Keys, KeyEvent> m_Keys = new Dictionary<Keys, KeyEvent>
        {
            { Keys.A,       KeyEvent.KEY_RELEASED },
            { Keys.D,       KeyEvent.KEY_RELEASED },
        };

        public void SetKeyPressed(Keys key)
        {
            m_Keys[key] = KeyEvent.KEY_PRESSED;
        }

        public void SetKeyReleased(Keys key)
        {
            m_Keys[key] = KeyEvent.KEY_RELEASED;
        }

        public bool IsKeyPressed(Keys key)
        {
            return m_Keys[key] == KeyEvent.KEY_PRESSED;
        }
    }
}
