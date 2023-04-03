using MediatR;

namespace $rootnamespace$
{
    public class $safeitemrootname$ : IRequestHandler<$fileinputname$Command, $fileinputname$CommandResult>
    {
    	public async Task<$fileinputname$CommandResult> Handle($fileinputname$Command request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
