package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.DisposalGuideline;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.DisposalGuidelineRepo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class DisposalGuidelineService extends com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service.Service<DisposalGuideline> {

    @Autowired
    private DisposalGuidelineRepo guidelineRepo;

    public List<DisposalGuideline> getAll() {
        return guidelineRepo.findAll();
    }

    public Optional<DisposalGuideline> getByID(Long id) {
        return guidelineRepo.findById(id);
    }

    public void deleteByID(Long id) {
        guidelineRepo.deleteById(id);
    }

    public DisposalGuideline update(Long id, DisposalGuideline newGuideline) {

        Optional<DisposalGuideline> oldGuideline = guidelineRepo.findById(id);

        if(oldGuideline.isPresent()){

            newGuideline.setType(newGuideline.getType().toLowerCase());
            DisposalGuideline updatedGuideline = oldGuideline.get();
            updatedGuideline.setDescription(newGuideline.getDescription());
            updatedGuideline.setType(newGuideline.getType());

            DisposalGuideline guidelineData = save(updatedGuideline);
            return guidelineData;
        }
        return null;
    }

    public DisposalGuideline save(DisposalGuideline guideline) {

        DisposalGuideline newGuidelineData =  guidelineRepo.save(guideline);
        return newGuidelineData;
    }
}
