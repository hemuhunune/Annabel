﻿using UnityEngine;
using System.Collections;

public class TalkSettings : MonoBehaviour
{
    public int startTalkNum = 0;

    TalkProcess talk;
    public int count = 0;


    void Start()
    {

        talk = GameObject.Find("GameControlObject").GetComponent<TalkProcess>();


    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {

            talk.endTalk();

        }
        if (count == 0) talkSet();
        count++;
    }


    /*会話時に使用する関数表一覧===========================================================================
		

		☆talk.setTalk( int talkNum , float drawTime , int drawFace , string charaName , string talkString );
			会話にセリフをセットします
				
			talkNum		登録する会話の識別番号、playTalkのtalkNumで呼び出したい番号をいれます
			drawTime	そのセリフを描画しておく時間です。秒単位
			drawFace	描画する顔グラの識別番号です。
			charaName	描画したいキャラクターの名前を入れます
			talkString	描画したいセリフを入れます



		☆talk.playTalk( int talkNum , int talkMode )
			会話を再生させます
			一旦playTalkで再生させるとその会話が終わるか、endTalk関数を呼び出すまで
			新しい会話は開始されません。

			talkNum		会話の識別番号を入れます。setTalkのtalkNumで入れた番号の会話が呼び出されます

			talkMode	会話のモードを入れます。
						talkModeが0プレイヤーが自ら会話を飛ばすモード、1がプレイヤーが飛ばさず時間で
						セリフが進むモードです。
						talkModeが0の時はアクションの操作は一切受け付けず、制限時間も止まります。

		☆talk.endTalk()
			現在再生されている会話を終了します。

	=====================================================================================================*/

    void talkSet()
    {
        //■000～099■Tutorial
        
        //■100～199■song
        talk.setTalk(100, 3.0f,  "？？？", "それはそれは昔のこと");
        talk.setTalk(100, 5.0f,  "？？？", "海際の街に");
        talk.setTalk(100, 7.0f,  "？？？", "ひとりの乙女が住んでいた");
        talk.setTalk(100, 8.0f,  "？？？", "その名はアナベル");
        talk.setTalk(100, 5.0f,  "？？？", "彼女はただひたすらに生きていた");
        talk.setTalk(100, 5.0f,  "？？？", "ただただ自分が愛されるために");

        talk.setTalk(103, 8.0f, "少女の声", "しかし彼女に不幸が訪れた");
        talk.setTalk(103, 8.0f, "少女の声", "海際の街で");
        talk.setTalk(103, 8.0f, "少女の声", "あなたに忘れ去られ殺してしまった");
        talk.setTalk(103, 8.0f, "少女の声", "美しい「アナベル」を");
        talk.setTalk(103, 8.0f, "少女の声", "そこで天上から使者が来て");
        talk.setTalk(103, 8.0f, "少女の声", "彼女を海から取り上げて遺跡の中に閉じ込めてしまった");
        talk.setTalk(103, 8.0f, "少女の声", "深く閉じた遺跡の中に");

        //■200～299■Stage1
        talk.setTalk(200, 3.0f, "主人公", "ねぇ・・・");
        talk.setTalk(200, 5.0f, "妖精人形", "ん？なに・・・？");
        talk.setTalk(200, 8.0f, "主人公", "ほんとにこっちでいいんだよね・・・？");
        talk.setTalk(200, 5.0f, "妖精人形", "うん、大丈夫だよ");
        talk.setTalk(200, 8.0f, "主人公", "ほんとに・・・あの子を救える？");
        talk.setTalk(200, 5.0f, "妖精人形", "あの子を呪いから解放するには・・・これしかないの");
        talk.setTalk(200, 8.0f, "主人公", "でも・・・私、魔法なんて・・・");
        talk.setTalk(200, 5.0f, "妖精人形", "大丈夫、私が協力するから");
        talk.setTalk(200, 8.0f, "主人公", "えっと・・・どうすれば");
        talk.setTalk(200, 5.0f, "妖精人形", "まずは進んでみよう、おそらく、悪い人形が出てくるはずだから");
        talk.setTalk(200, 8.0f, "主人公", "うん・・・頑張る");

        talk.setTalk(201, 8.0f, "妖精人形", "じゃあ、魔法の使い方教えるね");
        talk.setTalk(201, 8.0f, "主人公", "うん、お願い");
        talk.setTalk(201, 8.0f, "妖精人形", "まず、魔法を撃つには決定ボタンを押すんだ");
        talk.setTalk(201, 8.0f, "妖精人形", "魔法はロックオンしてる敵にかならず当たるように私が制御するから安心して");
        talk.setTalk(201, 8.0f, "妖精人形", "でも、ロックオンは１番近くの敵しかできないからね。そこは私の力不足が原因で・・・");
        talk.setTalk(201, 8.0f, "主人公", "うんうん、大丈夫。私の身体を通して魔法が使えるだけ十分だよ");
        talk.setTalk(201, 8.0f, "妖精人形", "ふふ、ありがとう");
        talk.setTalk(201, 8.0f, "妖精人形", "あと、キャンセルボタンでガードができるよ");
        talk.setTalk(201, 8.0f, "妖精人形", "ガードしている間は敵の攻撃を少し抑えれるんだ。でも、真正面からしか意味がないからね");
        talk.setTalk(201, 8.0f, "妖精人形", "また、タイミングよくガードを発動すると、ジャストガードができるよ");
        talk.setTalk(201, 8.0f, "主人公", "ジャストガード？");
        talk.setTalk(201, 8.0f, "妖精人形", "そう、あなたがうまく敵の攻撃をガードできるってことは、あなたの神経が研ぎ澄まされている証拠");
        talk.setTalk(201, 8.0f, "妖精人形", "その瞬間、私の封印されている力があなたによって引きずり出されるの");
        talk.setTalk(201, 8.0f, "主人公", "そしたら、どうなるの・・・？");
        talk.setTalk(201, 8.0f, "妖精人形", "特大の魔法を相手にお見舞いしてあげる！");
        talk.setTalk(201, 8.0f, "主人公", "頼もしい・・・");
        talk.setTalk(201, 8.0f, "妖精人形", "うん、それじゃ、大丈夫かな");
        talk.setTalk(201, 8.0f, "妖精人形", "決定ボタンで魔法、キャンセルボタンでガード、タイミングよくガードするとジャストガードで反撃");
        talk.setTalk(201, 8.0f, "妖精人形", "だいたいこんな感じかな");
        talk.setTalk(201, 8.0f, "主人公", "うん、ありがとう私、頑張るよ");

        //■300～399■Stage2
        talk.setTalk(300, 8.0f, "妖精人形", "すこし奥に進んできたね");
        talk.setTalk(300, 8.0f, "主人公", "ほんと？進んでる？");
        talk.setTalk(300, 8.0f, "妖精人形", "うん、アイツの力を、さっきより強く感じる");
        talk.setTalk(300, 8.0f, "主人公", "アイツ・・・");
        talk.setTalk(300, 8.0f, "妖精人形", "アナベル、ね");
        talk.setTalk(300, 8.0f, "主人公", "あの子に、呪いを与えたっていう・・・");
        talk.setTalk(300, 8.0f, "妖精人形", "そう、アイツの呪いで、あの子は動けない体になった・・・");
        talk.setTalk(300, 8.0f, "主人公", "・・・。");
        talk.setTalk(300, 8.0f, "主人公", "はやく・・・あの子を・・・救わないと");
        talk.setTalk(300, 8.0f, "妖精人形", "・・・ほんとにいいの？私はあなたを偶然選んだだけなのよ・・・？");
        talk.setTalk(300, 8.0f, "主人公", "うん、それでも。あの子ともう関わっちゃったし、見捨てておけないよ");
        talk.setTalk(300, 8.0f, "妖精人形", "・・・ありがとね");
        talk.setTalk(300, 8.0f, "主人公", "お礼なんていらないよ。さぁ、行こう");

        //■400～499■Stage2_Event
        talk.setTalk(400, 8.0f, "主人公", "この岩を破壊するにはどうすればいいんだろう…");
        talk.setTalk(400, 8.0f, "妖精人形", "さっき見つけた魔導書を貸して！");
        talk.setTalk(400, 8.0f, "妖精人形", "はぁぁぁあああ！");

        talk.endTalk();

        talk.playTalk(startTalkNum, 0);
    }

}