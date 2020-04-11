namespace KoiKoi {
    public class Gameplay_Load : SM_Gameplay_BaseState {
        public override void Enter () {
            context.screenFader.OnPlayEnd.AddListener( FadeInEndHandler );
        }

        private void FadeInEndHandler () {
            context.GoNext();
        }

        public override void Exit () {
            context.screenFader.OnPlayEnd.RemoveListener( FadeInEndHandler );
        }
    }
}