from abc import ABC, abstractmethod

class AbstractTask(ABC):
    @abstractmethod
    def display(self):
        pass

    @abstractmethod
    def mark_complete(self):
        pass