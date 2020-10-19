using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLab3.Exceptions
{
    class InvalidInputException : ApplicationException
    {
        private string messageDetails = string.Empty;
        public InvalidInputException() { }

        public InvalidInputException(string message)
        {
            messageDetails = message;
        }

        public override string Message
        {
            get
            {
                return "Error! Invalid Input Detected! " + this.messageDetails;
            }
        }
    }
}
