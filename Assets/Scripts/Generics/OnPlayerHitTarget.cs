using Generics;

namespace Generics
{
    public class OnPlayerHitTarget : InGameEvent<float>
    {
        public override void Raise(float variable)
        {
            base.Raise(variable);
        }

    }

    public class PlayerNicknameChange : InGameEvent<string>
    {
        public override void Raise(string variable)
        {
            base.Raise(variable);
        }
    }
    

}

public class TT
{
    public void abc ()
    {
        
        new GameEvent<NickName>().Raise(new NickName("22","22",""));
    }
}

public struct NickName
{
    private string name;
    private string nickname;
    private string hashCode;

    public NickName(string name, string nickname, string hashCode)
    {
        this.name = name;
        this.nickname = nickname;
        this.hashCode = hashCode;
    }
}
