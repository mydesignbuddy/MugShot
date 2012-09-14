using MugShot.Lib.Media;

namespace MugShot.Lib.Sources
{
    interface ISource
    {
        string Name { get; set; }
        string Description { get; set; }

        int RecursiveLevel { get; set; }

        void Create(IMedia media);
        void Read(int id);
        void Update(int id, IMedia media);
        void Delete(int id);
        void Index();
        void Index(int startNum, int limit);
    }
}
