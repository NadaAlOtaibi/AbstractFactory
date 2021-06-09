using System;
namespace ITaplets
{

    //Abstract factory interface

    public interface ITaplets
    {

        IPencil PencilShape();
        IKeyBoard KeyBoardSize();

    }


    //Concrete factories

    class Lenovo : ITaplets
    {
        public IPencil PencilShape()
        {
            return new LenovoPencil();
        }

        public IKeyBoard KeyBoardSize()
        {
            return new LenovoKeyBoard();
        } }


    class Apple : ITaplets
    {
        public IPencil PencilShape()
        {
            return new ApplePencil();
        }

        public IKeyBoard KeyBoardSize()
        {
            return new AppleKeyBoard();
        } } }