using System.Collections.Generic;

namespace Delegates
{
    public class PhotoFilters : IFilters
    {
        private readonly List<IEffect> _effects;

        public PhotoFilters()
        {
            _effects = new List<IEffect>();
        }

        public PhotoFilters(List<IEffect> effects)
        {
            _effects = effects;
        }
        public void AddEffect(IEffect effect)
        {
            _effects.Add(effect);
        }

        public void RemoveEffect(IEffect effect)
        {
            _effects.Remove(effect);
        }

        public List<IEffect> GetEffects()
        {
            return _effects;
        }
    }
}