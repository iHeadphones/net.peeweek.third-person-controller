namespace ThirdPersonController
{
    /// <summary>
    /// The character is in the air, and he jumped to achieve that
    /// </summary>
    public class AIJumpingCharacterState : AICharacterStateBase
    {
        public override void Update(Character character)
        {
            base.Update(character);

            if (character.IsGrounded)
            {
                this.ToState(character, AICharacterStateBase.GROUNDED_STATE);
            }
        }
    }
}
