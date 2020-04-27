using System;


namespace Return.Status
{
    /// <summary>
    /// Status Class is sed to Transport Status Messae Between, different Clasees
    /// </summary>
    public class Status : IEquatable<Status>
    {
        private bool errorOccurred;
        private string returnedMessage;
        private int returnedValue;
        private string customMessage;

        #region Constructor

        public Status(bool errorOccurred)
        {
            this.returnedMessage = "";
            this.errorOccurred = errorOccurred;
            this.returnedValue = 0;
            this.customMessage = string.Empty;
        }

        public Status(bool errorOccurred, string returnedMessage)
        {
            this.returnedMessage = returnedMessage;
            this.errorOccurred = errorOccurred;
            this.returnedValue = 0;
            this.customMessage = string.Empty;
        }

        public Status(bool errorOccurred, string returnedMessage, int returnedValue)
        {
            this.returnedMessage = returnedMessage;
            this.errorOccurred = errorOccurred;
            this.returnedValue = returnedValue;
            this.customMessage = string.Empty;
        }

        #endregion

        #region Properties

        public bool ErrorOccurred
        {
            set
            {
                errorOccurred = value;
            }
            get
            {
                return errorOccurred;
            }
        }

        public string CustomMessage
        {
            set
            {
                customMessage = value;
            }
            get
            {
                return customMessage;
            }
        }

        public string ReturnedMessage
        {
            set
            {
                returnedMessage = value;
            }
            get
            {
                return returnedMessage;
            }
        }

        public int ReturnedValue
        {
            set
            {
                returnedValue = value;
            }
            get
            {
                return returnedValue;
            }
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (!(obj is Status))
                return false;

            return Equals((Status)obj);
        }

        public bool Equals(Status other)
        {
            try
            {
                if (ReturnedMessage == null && other.ReturnedMessage == null)
                {
                    if (ErrorOccurred == other.ErrorOccurred && ReturnedValue == other.ReturnedValue)
                        return true;
                    else
                        return false;
                }
                else if (ReturnedMessage != null && other.ReturnedMessage != null)
                {
                    if (ErrorOccurred == other.ErrorOccurred && ReturnedValue == other.ReturnedValue
                        && ReturnedMessage.Equals(other.ReturnedMessage))
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }

            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public static bool operator ==(Status returnStatus1, Status returnStatus2)
        {
            return returnStatus1.Equals(returnStatus2);
        }

        public static Status operator +(Status returnStatus1, Status returnStatus2)
        {

            string linefeed = "\n\n";
            returnStatus1.ReturnedMessage += linefeed += returnStatus2.ReturnedMessage;
            returnStatus1.CustomMessage += linefeed += returnStatus2.CustomMessage;
            returnStatus1.ErrorOccurred |= returnStatus2.ErrorOccurred;
            returnStatus1.ReturnedValue += returnStatus2.ReturnedValue;
            return returnStatus1;

        }

        public static bool operator !=(Status returnStatus1, Status returnStatus2)
        {
            return !returnStatus1.Equals(returnStatus2);
        }

        public override int GetHashCode()
        {
            return returnedValue * returnedValue;
        }
    }
}
