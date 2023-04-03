using MediatR;

namespace $rootnamespace$
{
    public class $safeitemrootname$ : IRequestHandler<$fileinputname$Query, $fileinputname$QueryResult>
    {
    	public async Task<$fileinputname$QueryResult> Handle($fileinputname$Query request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
