using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace IOPrefix.LicenseKey_Validator
{
    public class LicenseKey_Validation
    {
        public void ValidateLicense(Entry license_key)
        {
            if (license_key.Text.Length == 5)
            {
                license_key.Text = license_key.Text.ToString().Trim() + "-";
            }
            else if (license_key.Text.Length == 10)
            {
                license_key.Text = license_key.Text.ToString().Trim() + "-";
            }
            else if (license_key.Text.Length == 15)
            {
                license_key.Text = license_key.Text.ToString().Trim() + "-";
            }
            else if (license_key.Text.Length == 20)
            {
                license_key.Text = license_key.Text.ToString().Trim() + "-";
            }
        }
    }
}
