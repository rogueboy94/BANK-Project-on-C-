using System.Windows.Forms;

namespace System
{
    internal class FormClosingEventArgs
    {
        private Action<object, Windows.Forms.FormClosingEventArgs> зарегистрироватьToolStripMenuItem_Click;

        public FormClosingEventArgs(Action<object, Windows.Forms.FormClosingEventArgs> зарегистрироватьToolStripMenuItem_Click)
        {
            this.зарегистрироватьToolStripMenuItem_Click = зарегистрироватьToolStripMenuItem_Click;
        }
    }
}