namespace KoiKoi {
	using UnityEngine;
	using Deirin.StateMachine;
	using Deirin.Tweeners;
	using System;

	public class SM_Gameplay : StateMachineBase {
		[Space, Header("Contex")]
		public GameplayContext context;

		protected override void CustomDataSetup () {
			context.Next += Next;
			data = context;
		}

		private void Next () {
			animator.SetTrigger( "Next" );
		}
	}

	[Serializable]
	public class GameplayContext : IStateMachineData {
		public Deck deck;
		public Board board;
		public Player playerA, playerB;
		public CanvasGroupTweener screenFader;

		public Action Next;

		public void GoNext () {
			Next?.Invoke();
		}
	} 
}