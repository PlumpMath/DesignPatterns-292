using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPattern
{
    public partial class Form1 : Form
    {
        private Stack<ConcreteCommand> undoCommands = new Stack<ConcreteCommand>();
        private Stack<ConcreteCommand> redoCommands = new Stack<ConcreteCommand>();

        public Form1()
        {
            InitializeComponent();
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;
            tbAllText.Text = 0.ToString();
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            undoCommands.Push(new ConcreteCommand(tbAllText, tbTextInput.Text));
            undoCommands.Peek().execute();
            enableButtons();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            ConcreteCommand command = undoCommands.Pop();
            redoCommands.Push(command);
            command.undo();
            enableButtons();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            ConcreteCommand command = redoCommands.Pop();
            undoCommands.Push(command);
            command.execute();
            enableButtons();
        }

        private void enableButtons()
        {
            if (undoCommands.Count == 0)
                btnUndo.Enabled = false;
            else
                btnUndo.Enabled = true;
            if (redoCommands.Count == 0)
                btnRedo.Enabled = false;
            else
                btnRedo.Enabled = true;
        }
    }
}
