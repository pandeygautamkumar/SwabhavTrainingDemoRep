using System;

namespace SimpleInterfaceApp.Model
{
    public interface ICrudable
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }
}
