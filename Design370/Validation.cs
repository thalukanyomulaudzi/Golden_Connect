using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Design370
{
    class Validation
    {
        public static bool validate(string text, string rule)
        {
            Regex regex;
            string pattern = "";
            if (rule == "name")
                pattern = "([A-Za-z]{2,})+";
            else if (rule == "id")
                pattern = @"^([0-9]{2})(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[0-9]{4}[01][89][0-9]$";
            else if (rule == "price")
                pattern = "^(R?[0-9]+([.][0-9]{2})?)$";
            else if (rule == "email")
                pattern = "^([A-Za-z,0-9]+)([.]{1}[A-Za-z,0-9]+)*[@]{1}([A-Za-z0-9]+)+([.]{1}[A-Za-z0-9]+)+$";
            else if (rule == "phone")
                pattern = "^([(]{1}[0-9]{3}[)]{1}[-]{1}[0-9]{3}[ ]?[0-9]{4})$|^([0-9]{3}[ ]?[0-9]{3}[ ]?[0-9]{4})|^([+]{1}[0-9]{1,3}[ ]?[0-9]{2,3}[ ]?[0-9]{3}[ ]?[0-9]{4})$";
            else
                throw new Exception("That regex rule is not valid");
            regex = new Regex(pattern);
            return regex.IsMatch(text);
        }

        public static void checkMark(System.Windows.Forms.Label lbl, bool isValid)
        {
            lbl.ForeColor = isValid ? Color.Green : Color.Red;
            lbl.Text = isValid ? "✓" : "✘";
        }
    }
}
