namespace KoiKoi {
    using UnityEngine;

    public class Gameplay_Load : SM_Gameplay_BaseState {
        public override void Enter () {
            context.screenFader.OnPlayEnd.AddListener( FadeInEndHandler );
            context.screenFader.Play();
        }

        private void FadeInEndHandler () {
            context.GoNext();
        }

        public override void Exit () {
            context.screenFader.OnPlayEnd.RemoveListener( FadeInEndHandler );

#if UNITY_EDITOR
            Debug.Log( "Load done!" );
#endif
        }
    }
}