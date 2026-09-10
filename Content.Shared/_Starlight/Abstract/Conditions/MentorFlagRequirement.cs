using Robust.Shared.Network;
using Robust.Shared.Player;
using Content.Shared.Administration;

namespace Content.Shared._Starlight.Abstract.Conditions;

public sealed partial class MentorFlagRequirement : BaseRequirement
{
    [DataField(required: true)]
    public NetUserId UserId;

    public override bool Handle(ICommonSession user)
    {
        base.Handle(user);
        var flags = AdminFlags.None;
        var isMentor = flags.HasFlag(AdminFlags.RNSLMentor);

        return isMentor;
    }
}
