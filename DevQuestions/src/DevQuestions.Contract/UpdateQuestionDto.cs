namespace DevQuestions.Contract;

public record UpdateQuestionDto(string Title, string Body,Guid[] TagIds);