using System;
namespace ITaplets
{


    public interface IPencil
    {
        string PencilB();
    }

    class LenovoPencil : IPencil
    {
        public string PencilB()
        {
            return "Lenovo Pencil";
        }
    }

    class ApplePencil : IPencil
    {
        public string PencilB()
        {
            return "Apple Pencil";
        }
    }

    public interface IKeyBoard
    {
        string KeyBoardB();
    }

    class LenovoKeyBoard : IKeyBoard
    {
        public string KeyBoardB()
        {
            return "Lenovo KeyBoard";
        }
    }

    class AppleKeyBoard : IKeyBoard
    {
        public string KeyBoardB()
        {
            return "Apple KeyBoard";
        }
    }
}