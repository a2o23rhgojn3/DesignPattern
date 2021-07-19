なぜFactoryMethodパターンが必要なのか
＊newによるインスタンス生成をインスタンス生成のためのメソッドに変えることで、具体的なクラス名を
　記述することを防ぐことができる。（＝依存していない）

	・frameworkパッケージのクラスには、IDCardやIDCardFactoryといったクラス名が記載されていない。
		→つまり、新しくCashCardやCashCardFactoryといったクラスを追加するとしても、
		  frameworkは変更する必要なく実装することができる。