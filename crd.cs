using Pulumi;
using Kubernetes = Pulumi.Kubernetes;
using Pulumi.Kubernetes.Types.Inputs.Core.V1;
using Pulumi.Kubernetes.Types.Inputs.Apps.V1;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;
using Pulumi.Kubernetes.Types.Inputs.Rbac.V1;
using Pulumi.Kubernetes.Core.V1;
using Pulumi.Kubernetes.ApiExtensions;


class StackArgs : CustomResourceArgs
{
    [Input("spec")]
    public Input<StackSpecArgs>? Spec { get; set; }

    public StackArgs() : base("pulumi.com/v1", "Stack")
    {
    }
}

class StackSpecArgs : ResourceArgs
{
    [Input("accessTokenSecret")]
    public Input<string>? AccessTokenSecret { get; set; }
    
    [Input("envSecrets")]
    public InputList<string>? EnvSecrets { get; set; }

    [Input("stack")]
    public Input<string>? Stack { get; set; }

    [Input("projectRepo")]
    public Input<string>? ProjectRepo { get; set; }

    [Input("branch")]
    public Input<string>? Branch { get; set; }

    [Input("destroyOnFinalize")]
    public Input<bool>? DestroyOnFinalize { get; set; }
}