using System;

namespace IdentificationNoCheckDigit
{
    public class CheckDigit
    {
    public int CalLastID(long id)
        {
            string stringId = id.ToString();
            if (stringId.Length == 13) 
            {
                int sum = 0;
                for ( int var=0 ; var<12; var++)
                {

                    sum += (Convert.ToInt32((stringId.ToCharArray()[var]).ToString()) * (13-var));
                }
                int output = (11- (sum%11) );
                return output;
            }
            return -1;

        }
    }
}
