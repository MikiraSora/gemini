using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemini.Framework.Languages
{
    public interface ILanguageManager
    {
        public IEnumerable<string> GetAvaliableLanguageNames();
        public void SetLanguage(string languageName);
        public string GetCurrentLanguage();
    }
}
