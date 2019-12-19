using System.Collections.Generic;

namespace Delegates
{
    public interface IFilters
    {
        void AddEffect(IEffect effect);
        void RemoveEffect(IEffect effect);
        List<IEffect> GetEffects();
    }
}