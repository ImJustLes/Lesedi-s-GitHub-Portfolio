package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.DisposalGuideline;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.DisposalGuidelineRepo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class DisposalGuidelineService extends com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service.Service<DisposalGuideline> {

    //Gets the repo for the Guidelines
    @Autowired
    private DisposalGuidelineRepo guidelineRepo;

    //Gets all the guidelines from the database.
    public List<DisposalGuideline> getAll() {
        return guidelineRepo.findAll();
    }

    //Gets all the guidelines, by id, from the database.
    public Optional<DisposalGuideline> getByID(Long id) {
        return guidelineRepo.findById(id);
    }

    //Deletes the guidelines, by id, from the database.
    public void deleteByID(Long id) {
        guidelineRepo.deleteById(id);
    }

    //Updates the guideline, by idd, with the new guideline information.
    public DisposalGuideline update(Long id, DisposalGuideline newGuideline) {

        Optional<DisposalGuideline> oldGuideline = guidelineRepo.findById(id);

        if(oldGuideline.isPresent()){

            //Making the type of guideline lower case for input sanitsation.
            newGuideline.setType(newGuideline.getType().toLowerCase());            
            DisposalGuideline updatedGuideline = oldGuideline.get();

            //Updating the old guideline with the new guideline information.
            updatedGuideline.setDescription(newGuideline.getDescription());
            updatedGuideline.setType(newGuideline.getType());

            DisposalGuideline guidelineData = save(updatedGuideline);
            return guidelineData;
        }
        return null;
    }

    //Saves the new guideline into the database.
    public DisposalGuideline save(DisposalGuideline guideline) {

        //Making the type of guideline lower case for input sanitsation.
        guideline.setType(guideline.getType().toLowerCase());  
        
        DisposalGuideline newGuidelineData =  guidelineRepo.save(guideline);
        return newGuidelineData;
    }
}
