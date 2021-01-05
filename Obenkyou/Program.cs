using System;

namespace Obenkyou
{
    class Program
    {
        static void Main(string[] args)
        {
            //コンソールプログラムではMainメソッドがエントリポイント(プログラム起動時に呼び出されるメソッド)となる
            Console.WriteLine("ここからプログラムを開始する");

            //①下で定義しているメソッドを呼び出す
            TestFunction();

            //②文字列の引数を渡してメソッドを呼び出す
            TestFunction2("引数を渡す！");

            //③引数を渡し、結果を受け取る
            int result = 0;
            result = TestFunction3(10, 20);
            Console.WriteLine("TestFunction3から返された値は{0}です！", result);

            //Mainメソッドの終了はプログラムの終了と同じ
            Console.WriteLine("プログラムが終了");

        }

        //【メソッド定義】
        // static <戻り値の型> <メソッド名>(<仮引数>)
        // <戻り値の型> ：戻り値がない場合void
        //              ：戻り値がある場合はその型
        // <メソッド名> ：予約語・既存のメソッド名とかぶらない自由な名前を付ける
        // <仮引数>     ：存在しない場合は()
        //              ：存在する場合、型と名前を指定する
        //              ：カンマで区切り、複数個指定できる

        /// <summary>
        /// テスト用関数1:引数なし
        /// </summary>
        static void TestFunction()
        {
            //Programクラス内にメソッドを作成すると、Mainメソッド内で呼び出すことができる
            Console.WriteLine("TestFunctionの呼び出しに成功！");
        }

        /// <summary>
        /// テスト用関数2:引数あり
        /// </summary>
        /// <param name="arg">テスト用関数に渡す文字列の引数。</param>
        static void TestFunction2(string arg)
        {
            //値を受け取り、メソッド内の処理にそれを使用することができる！
            Console.WriteLine("TestFunction2で受け取った文字列は「{0}」です！", arg);
        }

        /// <summary>
        /// テスト用関数3:戻り値あり
        /// </summary>
        /// <param name="x">足す数</param>
        /// <param name="y">足される数</param>
        /// <returns></returns>
        static int TestFunction3(int x,int y)
        {
            //受け取った値で計算を行う
            var result = x + y;

            //計算結果を呼び出し元へ返す
            return result;
        }
    }
}