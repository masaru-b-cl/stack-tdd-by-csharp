「車窓からのTDD」 by C#
=====

本文書は北野弘治氏による「[車窓からのTDD - オブラブ(旧オブジェクト倶楽部)](http://objectclub.jp/technicaldoc/testing/stack_tdd.pdf)」を元に、平鍋健児氏([@hiranabe](https://twitter.com/hiranabe))の許諾を得て作成したものです。

本文書では、Visual StudioとC#を用いて「車窓からのTDD」の各ステップを追体験することで、「テスト駆動開発(TDD)」の最初の一歩を踏み出せるようになることを目的としています。本書とともに「車窓からのTDD」も併せて読み進めてください。


想定する読者
-----

- VSとC#で簡単なプログラムを作れる
- テスト駆動開発とはどんなものであるのか知らない
- VSとC#でTDDを行うための手順を知りたい


本文書の開発環境
-----

- Windows 10 Pro 64bit (Fall Creators Update)
- Visual Studio 2017 Community
- .NET Framework 4.7.1 (not Core)
- xUnit\.net 2.3.1

目次
-----

1. [米原駅 ～すべてはここから始まった～](doc/01.md)
2. [長浜駅 ～Assert ファースト～](doc/02.md)
3. [長浜と敦賀の間 ～最初は赤で、次に緑、そしてリファクタリング！！～](doc/03.md)
4. [敦賀駅 ～とらいあんぎゅれーしょん？？～](doc/04.md)
5. [北陸トンネルね！いっちょらい！ ～Exception テスト～](doc/05.md)
6. [トンネルを抜けると、そこは？！ ～TDD ラストスパート～](doc/06.md)

参考資料
-----

- [車窓からのTDD - オブラブ](http://objectclub.jp/technicaldoc/testing/stack_tdd.pdf)
- [Getting Started with xUnit.net (desktop) > xUnit.net](http://xunit.github.io/docs/getting-started-desktop)


ライセンス
-----

![クリエイティブ・コモンズ・ライセンス](https://i.creativecommons.org/l/by-sa/4.0/88x31.png)

この 作品 は [クリエイティブ・コモンズ 表示 - 継承 4.0 国際 ライセンス](http://creativecommons.org/licenses/by-sa/4.0/") の下に提供されています。
