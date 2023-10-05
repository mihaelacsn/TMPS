from abc import ABC, abstractmethod
from src.task import Task
from src.taskEditor import TaskEditor

class AbstractTaskFactory(ABC):
    @abstractmethod
    def create_task(self, name):
        pass

    @abstractmethod
    def create_task_editor(self, name):
        pass

class SimpleTaskFactory(AbstractTaskFactory):
    def create_task(self, name):
        return Task(name)

    def create_task_editor(self, name):
        return TaskEditor(name)
