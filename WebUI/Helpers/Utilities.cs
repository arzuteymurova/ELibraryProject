using System;

namespace WebUI.Helpers
{
    public class Utilities
    {
        public bool IsNullOrEmpty(string text)
        {
            if (text == null | text == "") return true;
            return false;
        }

        public void Check(Func<string, bool> condition, string text, Action ifTrue, Action ifFalse)
        {
            if (!condition.Invoke(text))
            {
                ifTrue.Invoke();
            }
            else
            {
                ifFalse.Invoke();
            }
        }
        public void Check(Func<string, bool> condition, string text, Action ifTrue)
        {
            if (!condition.Invoke(text))
            {
                ifTrue.Invoke();
            }

        }
    }
}
