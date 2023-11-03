using Application.ABSTRACTIONS;

namespace Application.BE
{
    public class Translation : ITranslation
    {
        public string Key { get; set; }
        public string Translate { get; set; }
    }
}
