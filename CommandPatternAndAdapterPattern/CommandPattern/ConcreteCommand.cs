using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPattern
{
    public class ConcreteCommand : Command
    {
        private double addNum;
        private double previousNum;
        private string previousText;
        private RichTextBox textBox;
        private NumberGetter numGetter = new NumberGetter();
        public ConcreteCommand(RichTextBox tb, string text)
        {
            this.textBox = tb;
            this.previousNum = numGetter.getNumber(tb.Text, tb.Text.Contains("."));
            this.addNum = numGetter.getNumber(text, text.Contains("."));
            this.previousText = tb.Text;
        }

        public void execute()
        {
            textBox.Text = (previousNum + addNum).ToString();
        }

        public void undo()
        {
            textBox.Text = previousNum.ToString();
        }
    }
}
