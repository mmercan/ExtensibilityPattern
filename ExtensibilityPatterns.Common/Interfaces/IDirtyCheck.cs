using System.ComponentModel;

namespace ExtensibilityPatterns.Common.Interfaces
{
    public interface IDirtyCheck : INotifyPropertyChanged
    {
        bool IsDirty { get; set; }

    }
}