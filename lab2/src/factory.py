from abc import ABC, abstractmethod
from src.task import Task
from src.taskEditor import TaskEditor

class TaskFactory(ABC):
    @abstractmethod
    def create_task(self, name):
        pass

class SimpleTaskFactory(TaskFactory):
    def create_task(self, name):
        return Task(name)

class EditorTaskFactory(TaskFactory):
    def create_task(self, name):
        return TaskEditor(name)
