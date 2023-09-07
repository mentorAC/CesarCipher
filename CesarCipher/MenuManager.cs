namespace CesarCipher
{
    internal class MenuManager
    {
        public static void Show()
        {
            Console.WriteLine(
                "Menu: \n" +
              "1) Exit\n" +
              "2) Clear\n" +
              "3) Coding\n" +
              "4) Encoding\n->");
        }

        public static MenuTypes Read()
        {
            int key_01 = int.Parse(Console.ReadLine());
            switch (key_01)
            {
                case 1: return MenuTypes.EXIT;
                case 2: return MenuTypes.CLEAR;
                case 3: return MenuTypes.CODING;
                case 4: return MenuTypes.ENDCODING;
                default: return MenuTypes.NONE;
            }

            //return key_01 switch
            //{
            //    1 => MenuTypes.EXIT,
            //    2 => MenuTypes.CLEAR,
            //    3 => MenuTypes.CODING,
            //    4 => MenuTypes.ENDCODING,
            //    _ => MenuTypes.NONE,
            //};
        }
    }

}
