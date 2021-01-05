using System;

namespace Obenkyou
{
    class Program
    {
        static void Main(string[] args)
        {
            //コンソールプログラムではMainメソッドがエントリポイント(プログラム起動時に呼び出されるメソッド)となる
            Console.WriteLine("ここからプログラムを開始する");

            //「//」を文頭に置くとその行はコメントになる
            //コメントはコードとして扱われないため、メモに使用できる
            //Visual Studioから開くと、緑色で表示される(わかりやすい)

            //識別子には大文字・小文字の区別が存在する

            //【Console.WriteLineメソッド】
            //Console.WriteLine(<文字列>);で、文字列を表示できる
            //C#では、文字列を「"」でかこって表現する

            //console.writeline("obenkyou");　←エラー(小文字になっているため)
            //Console.WriteLine(obenkyou);　←エラー(""で囲われていないため、識別子として扱われる)
            Console.WriteLine("obenkyou");

            //Console.WriteLine(<複合書式設定文字列>,<変数>...);で、文字列に値を埋め込んで表示できる！
            //中かっこ(「{}」)の中に0から始まる数値を指定すると、対応する箇所の値が置換されて表示される
            Console.WriteLine("オワオワかよ"); //普通の文字列
            Console.WriteLine("{0}かよ", "オワオワ"); //一つ目の値「オワオワ」で{0}が置換され、出力は「オワオワかよ」になる！
            Console.WriteLine("{0}{2}{1}", "雑", "乙", "魚"); //対応する順番の値で置換されるため、出力は「雑魚乙」になる！
            //Console.WriteLine("{5}{6}{7}", "雑", "乙", "魚"); //中かっこ内の値は必ず0から順に指定する必要がある。このステートメントは実行時エラーとなる
            Console.WriteLine("{0}", "雑", "乙"); //値の数は多くても実行時エラーとはならないが、当然出力はされない。「雑」が出力される

            //【メソッド呼び出し】
            //①下で定義しているメソッドを呼び出す
            TestFunction();

            //②文字列の引数を渡してメソッドを呼び出す
            TestFunction2("引数を渡す！");

            //③引数を渡し、結果を受け取る
            int result = 0;
            result = TestFunction3(10, 20);
            Console.WriteLine("TestFunction3から返された値は{0}です！", result);

            //【変数定義】
            //<型名> <変数名>で自由に変数を定義できる
            int intvar1 = 15;
            int intvar2 = 30;
            string strvar = "文字列変数";

            //メソッドには変数を渡すこともできる
            TestFunction2(strvar);

            int resultarg = 0;
            resultarg = TestFunction3(intvar1, intvar2);
            Console.WriteLine("TestFunction3から返された値は{0}です！", resultarg);

            //Mainメソッドの終了はコンソールプログラムの終了と同じ
            Console.WriteLine("プログラムが終了");

        }

        //【メソッド定義】
        // static <戻り値の型> <メソッド名>(<仮引数>)
        // static       ：おまじない(静的メソッドであることを表す)
        // <戻り値の型> ：戻り値がない場合void
        //              ：戻り値がある場合はその型
        // <メソッド名> ：予約語・既存のメソッド名とかぶらない自由な名前を付ける
        // <仮引数>     ：存在しない場合は()
        //              ：存在する場合、型と名前を指定する
        //              ：カンマで区切り、複数個指定できる

        //Programクラス内に定義する場合、以下のように書く

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

            //計算結果を呼び出し元へ返す！
            return result;
        }
    }
}