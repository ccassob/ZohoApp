using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoApp.App
{
    public interface ITransformHistory
    {
        string Transform(TransformHistoryDto transformHistoryDto);
    }

    public enum Actions
    {
        None = -1,
        Begin,
        Continue,
        End
    }

    public class TransformHistoryDto
    {
        public string History { get; set; }
        public string FirstTask { get; set; }
        public string SecondTask { get; set; }
        public Actions Actions { get; set; }
    }
}
