# MediatR C# Templates

Useful VS templates to create Commands & Queries from MediatR nuget package in Visual Studio. 

Helps devs to reduce time of creating C# classes for Commands & Queries via using VS templates.

# Installation

1. Clone repo or just download **.zip** temlates.
2. Put **.zip** temlates to 
```path
Users/%user%/Documents/VusialStudio (2022/2019/...)/Templates/ItemTemplates
```
3. Launch Visual Studio.

4. On any cs project/folder click "**Add new element**".
5. Select "**Command (MR)**" or "**Query (MR)**".
6. Write name **without** "Command" or "Query".
7. Enjoy!

# Examples

ToDo: Create **Login** command.
1. Create "**Login**" folder.
2. Click "Add new element" and select "Command (MR)".
3. Write "**Login**" in name and click "Add".
4. 3 files will be added.

**LoginCommand.cs**:
```C#
public record LoginCommand() : IRequest<LoginCommandResult>;
```

**LoginHandlerCommand.cs**:
```C#
public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginCommandResult>
    {
        public async Task<LoginCommandResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
```

**LoginCommandResult.cs**:
```C#
public record LoginCommandResult();
```

# Change template

If you want to change smth in template, so you can.

You need to:
1. Do changes in **.cs** files.
2. Create **.zip** file with updated files.
3. Put **.zip** temlates to 
```path
Users/%user%/Documents/VusialStudio (2022/2019/...)/Templates/ItemTemplates
```

