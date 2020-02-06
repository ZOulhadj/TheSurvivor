using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSurvivor.Source
{
    enum Key
    {
        KEY_A,
        KEY_D,
        KEY_SPACE,
        KEY_ESCAPE,
        KEY_NONE
    }

    class Input
    {
        private Key m_CurrentKey = Key.KEY_NONE;


        public void SetKeyDown(Keys keys)
        {
            switch (keys)
            {
                case Keys.A:
                    m_CurrentKey = Key.KEY_A;
                break;
                case Keys.D:
                    m_CurrentKey = Key.KEY_D;
                    break;
                case Keys.Space:
                    m_CurrentKey = Key.KEY_SPACE;
                    break;
                case Keys.Escape:
                    m_CurrentKey = Key.KEY_ESCAPE;
                    break;
            }
        }

        public void SetKeyReleased()
        {
            m_CurrentKey = Key.KEY_NONE;
        }

        public Key GetCurrentKey() { return m_CurrentKey; }
    }
}
