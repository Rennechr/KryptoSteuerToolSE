using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KryptoSteuernTool
{
    internal class Validator
    {
        public bool check(string[] rules, params object[] objects)
        {
            bool valid = true;
            int it = 0;
            foreach (object o in objects)
            {
                if(rules[it] == "required")
                {
                    if (o.GetType().GetProperty("Text") == null || o.GetType().GetProperty("Text").GetValue(o).ToString().Length < 1)
                    {
                        return false;
                    }
                }
                else if(rules[it] == "singleRadioSelected")
                {
                    var temp = o.GetType().GetProperty("Controls").GetValue(o);
                    IList RadioButtonsInGroupBox = (IList)temp;
                    int count = 0;
                    foreach (RadioButton radioButton in RadioButtonsInGroupBox)
                    {
                        if(radioButton.Checked == true)
                        {
                            count++;
                        }
                    }
                    if (count != 1)
                    {
                        return false;
                    }

                }
                else
                {
                    
                    if(rules[it]== "" || rules[it] == null)
                    {
                        throw new ArgumentNullException("No argument passed To validator function at position "+ it.ToString());
                    }
                    throw new NotImplementedException("This rule is not implemented \n" + rules[it]);
                }
                it++;
            }
            return valid;
        }
      
    }
}