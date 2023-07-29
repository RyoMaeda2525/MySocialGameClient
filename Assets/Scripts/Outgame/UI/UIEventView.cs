using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Outgame
{
    public class UIEventView : UIStackableView
    {
        [SerializeField, Header("�C�x���g�N�G�X�g�̃{�^����\�����邩�Ǘ�����")]
        GameObject _eventQuestButton;

        protected override void AwakeCall()
        {
            ViewId = ViewID.Event;
            _hasPopUI = true;
        }

        private void EventOpenCheck() 
        {
            _eventQuestButton.SetActive(EventHelper.IsEventGamePlayable(1));
        }

        public override void Enter()
        {
            base.Enter();

            UIStatusBar.Show();

            Debug.Log(EventHelper.GetAllOpenedEvent());
            Debug.Log(EventHelper.IsEventOpen(1));
            Debug.Log(EventHelper.IsEventGamePlayable(1));

            EventOpenCheck();
        }

        public void GoHome() 
        {
            UIManager.NextView(ViewID.Home);
        }

        public void GoEventQuest()
        {
            UIManager.NextView(ViewID.EventQuest);
        }

        public void GoEventRanking() 
        {
            UIManager.NextView(ViewID.EventRanking);
        }

        public void DialogTest()
        {
            UICommonDialog.OpenOKDialog("�e�X�g", "�e�X�g�_�C�A���O�ł���", Test);
        }

        void Test(int type)
        {
            Debug.Log("here");
        }
    }
}
