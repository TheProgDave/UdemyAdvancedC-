namespace Delegates
{
    public class PhotoProcessor
    {
        private readonly IFilters _filters;
        private readonly IPicture _pic;

        public PhotoProcessor(IFilters filters, IPicture pic)
        {
            _filters = filters;
            _pic = pic;
        }
        
        public void Process()
        {
            foreach (var effect in _filters.GetEffects())
            {
                effect.Apply(_pic);
            }
            _pic.Save();
        }
    }
}