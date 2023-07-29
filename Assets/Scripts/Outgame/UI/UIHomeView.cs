using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.PackageManager;
using UnityEngine;


namespace Outgame
{
    public class UIHomeView : UIStackableView
    {
        [SerializeField, Header("イベントのボタンを表示するか管理する")]
        GameObject _eventButton;

        protected override void AwakeCall()
        {
            ViewId = ViewID.Home;
            _hasPopUI = true;
        }

        private void EventCheck() 
        {
            _eventButton.SetActive(EventHelper.IsEventOpen(1));
        }

        public override void Enter()
        {
            base.Enter();

            UIStatusBar.Show();

            Debug.Log(EventHelper.GetAllOpenedEvent());
            Debug.Log(EventHelper.IsEventOpen(1));
            Debug.Log(EventHelper.IsEventGamePlayable(1));

            EventCheck();
        }

        public void GoGacha()
        {
            UIManager.NextView(ViewID.Gacha);
        }

        public void GoCardList()
        {
            UIManager.NextView(ViewID.CardList);
        }

        public void GoEnhance()
        {
            UIManager.NextView(ViewID.Enhance);
        }

        public void GoQuest()
        {
            UIManager.NextView(ViewID.Quest);
        }

        public void GoEvent() 
        {
            UIManager.NextView(ViewID.Event);
        }

        public void DialogTest()
        {
            UICommonDialog.OpenOKDialog("テスト", "テストダイアログですよ", Test);
        }

        void Test(int type)
        {
            Debug.Log("here");
        }
    }
}
